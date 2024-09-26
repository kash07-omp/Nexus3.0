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
                .FirstOrDefaultAsync(ss => ss.Id == id);

            if (solarSystem == null)
            {
                return NotFound();
            }

            var viewModel = new SolarSystemViewModel
            {
                SolarSystem = solarSystem,
                CurrentUser = await _userManager.GetUserAsync(User)
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> MoveFleet(int fleetId, int destinationX, int destinationY)
        {
            var fleet = await _context.Fleets.Include(f => f.SolarSystem).FirstOrDefaultAsync(f => f.Id == fleetId);
            if (fleet == null) return NotFound();

            var path = await _fleetMovementService.CalculatePath(fleet, (destinationX, destinationY));

            if (path == null) return BadRequest("No valid path found.");

            var slowestSpeed = fleet.FleetShips.Min(fs => fs.Ship.Speed); // Get slowest ship in the fleet
            var travelTimePerStep = TimeSpan.FromSeconds(slowestSpeed * 10); // Calculate time per step

            await _fleetMovementService.SaveFleetPath(fleet, path, travelTimePerStep);

            return Json(new { success = true });
        }

    }
}
