using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Nexus.Domain.Entities;
using Nexus.Infrastructure.Data;
using Nexus.Web.Models;

namespace Nexus.Web.Services.UserRegister
{
    public class UserRegisterService : IUserRegisterService
    {
        private readonly ApplicationDbContext _context;
        private readonly UniverseSettings _universeSettings;

        public UserRegisterService(ApplicationDbContext context, IOptions<UniverseSettings> universeSettings)
        {
            _context = context;
            _universeSettings = universeSettings.Value;
        }

        public async Task<Region> AssignUserToRegionAsync(User user)
        {
            double emptyPlanetProbability = _universeSettings.EmptyPlanetProbability;
            Random rand = new Random();
            Region assignedRegion = null;

            // Decide si se asignará un planeta vacío
            bool assignEmptyPlanet = rand.NextDouble() < emptyPlanetProbability;

            if (assignEmptyPlanet)
            {
                // Buscar un planeta vacío
                var emptyPlanets = await _context.Planets
                    .Where(p => !p.Regions.Any(r => r.UserId != null))
                    .ToListAsync();

                if (emptyPlanets.Any())
                {
                    var selectedPlanet = emptyPlanets[rand.Next(emptyPlanets.Count)];
                    assignedRegion = await _context.Regions
                        .FirstOrDefaultAsync(r => r.PlanetId == selectedPlanet.Id && r.UserId == null);
                }
            }

            // Si no se asigna un planeta vacío o no se encuentra uno, asignar una región cualquiera
            if (assignedRegion == null)
            {
                assignedRegion = await _context.Regions
                    .Where(r => r.UserId == null)
                    .OrderBy(r => Guid.NewGuid()) // Seleccionar aleatoriamente
                    .FirstOrDefaultAsync();
            }

            if (assignedRegion != null)
            {
                assignedRegion.UserId = user.Id;
                await _context.SaveChangesAsync();
            }

            return assignedRegion;
        }
    }
}
