using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
using Nexus.Infrastructure.Data;
using Nexus.Infrastructure.Services.Interfaces;

namespace Nexus.Infrastructure.Services
{
    public class ShipConstructionService : IShipConstructionService
    {
        private readonly ApplicationDbContext _context;

        public ShipConstructionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task ProcessCompletedShipConstructionsAsync(int regionId)
        {
            var now = DateTime.UtcNow;

            var completedShips = await _context.ShipBuildQueues
                .Where(sbq => sbq.RegionId == regionId && sbq.CompletionTime <= now)
                .ToListAsync();

            foreach (var shipBuild in completedShips)
            {
                // Agregar la nave a la flota
                var fleetShip = await _context.FleetShips
                    .FirstOrDefaultAsync(fs => fs.FleetId == shipBuild.FleetId && fs.ShipId == shipBuild.ShipId);

                if (fleetShip != null)
                {
                    fleetShip.Quantity += 1;
                }
                else
                {
                    _context.FleetShips.Add(new FleetShip
                    {
                        FleetId = shipBuild.FleetId,
                        ShipId = shipBuild.ShipId,
                        Quantity = 1
                    });
                }

                // Eliminar la entrada de la cola
                _context.ShipBuildQueues.Remove(shipBuild);
            }

            await _context.SaveChangesAsync();
        }
    }
}
