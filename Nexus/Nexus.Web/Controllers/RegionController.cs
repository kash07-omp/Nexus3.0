using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus.Infrastructure.Data;
using Nexus.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Nexus.Web.Models;
using Nexus.Infrastructure.Services;

namespace Nexus.Web.Controllers
{
    public class RegionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly ResourcesService _resourcesService;
        private readonly StructureUpgradeService _structureUpgradeService;

        public RegionController(ApplicationDbContext context, UserManager<User> userManager, ResourcesService resourcesService, StructureUpgradeService structureUpgradeService)
        {
            _context = context;
            _userManager = userManager;
            _resourcesService = resourcesService;
            _structureUpgradeService = structureUpgradeService;
        }

        // Método Index para listar todas las regiones del jugador
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var regions = await _context.Regions
                .Where(r => r.UserId == userId)
                .Include(r => r.Planet)
                .ToListAsync();
            return View(regions);
        }

        public async Task<IActionResult> Detail(int id)
        {
            await _resourcesService.UpdateRegionResourcesAsync(id);
            await _structureUpgradeService.ProcessCompletedUpgradesAsync(id);

            var region = await _context.Regions
                .Include(r => r.Planet)
                .Include(r => r.RegionStructures)
                    .ThenInclude(rs => rs.Structure)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (region == null)
            {
                return NotFound();
            }

            var districts = await _context.Districts.ToListAsync();
            var structures = await _context.Structures.ToListAsync();
            var regionStructures = region.RegionStructures.ToList();

            var viewModel = new RegionViewModel
            {
                Region = region,
                Districts = districts,
                Structures = structures,
                RegionStructures = regionStructures
            };

            return View(viewModel);
        }

    }
}
