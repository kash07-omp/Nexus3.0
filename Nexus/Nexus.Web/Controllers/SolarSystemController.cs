using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus.Infrastructure.Data;
using Nexus.Domain.Entities;
using Nexus.Web.Models;
using Microsoft.AspNet.Identity;
using Nexus.Web.Services.UserRegister;
using Microsoft.AspNetCore.Identity;
using Nexus.Infrastructure.Services.Interfaces;

namespace Nexus.Web.Controllers
{
    public class SolarSystemController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRegisterService _userRegisterService;
        private readonly IFleetMovementService _fleetMovementService;
        private readonly Microsoft.AspNetCore.Identity.UserManager<User> _userManager;

        public SolarSystemController(
            ApplicationDbContext context,
            IUserRegisterService userRegisterService,
            Microsoft.AspNetCore.Identity.UserManager<User> userManager,
            IFleetMovementService fleetMovementService)
        {
            _context = context;
            _userRegisterService = userRegisterService;
            _userManager = userManager;
            _userManager = userManager;
            _fleetMovementService = fleetMovementService;
        }

        public async Task<IActionResult> Detail(int id)
        {
            var solarSystem = await _context.SolarSystems
                .Include(ss => ss.Planets)
                    .ThenInclude(p => p.Regions)
                .Include(ss => ss.AsteroidFields)
                .Include(ss => ss.JumpGates)
                .Include(ss => ss.Fleets)
                    .ThenInclude(f => f.FleetMovementPaths)
                .FirstOrDefaultAsync(ss => ss.Id == id);

            if (solarSystem == null)
            {
                return NotFound();
            }

            // Actualizar las posiciones de las flotas
            await _fleetMovementService.UpdateFleetPositions(solarSystem.Fleets.ToList());

            var viewModel = new SolarSystemViewModel
            {
                SolarSystem = solarSystem,
                CurrentUser = await _userManager.GetUserAsync(User),
                FleetMovements = solarSystem.Fleets.SelectMany(f => f.FleetMovementPaths).ToList()
            };

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> MoveFleet(int fleetId, int destinationX, int destinationY)
        {
            // Obtener la flota con las relaciones necesarias
            var fleet = await _context.Fleets
                .Include(f => f.SolarSystem)
                .Include(f => f.FleetShips)
                    .ThenInclude(fs => fs.Ship)
                .FirstOrDefaultAsync(f => f.Id == fleetId);

            if (fleet == null)
                return NotFound();

            // Eliminar todos los registros de FleetMovementPaths asociados a la flota
            var existingPaths = await _context.FleetMovementPaths
                .Where(fmp => fmp.FleetId == fleetId)
                .ToListAsync();

            if (existingPaths.Any())
            {
                _context.FleetMovementPaths.RemoveRange(existingPaths);
            }

            // Calcular la nueva ruta de la flota
            var path = await _fleetMovementService.CalculatePath(fleet, (destinationX, destinationY));

            if (path == null)
                return BadRequest("No valid path found.");

            // Guardar los nuevos movimientos de la flota en la base de datos
            _context.FleetMovementPaths.AddRange(path);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }


    }
}
