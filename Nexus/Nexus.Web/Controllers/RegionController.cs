using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus.Infrastructure.Data;
using Nexus.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Nexus.Web.Models;
using Nexus.Infrastructure.Services;
using Nexus.Infrastructure.Services.Interfaces;

namespace Nexus.Web.Controllers
{
    public class RegionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IResourceService _resourcesService;
        private readonly IStructureUpgradeService _structureUpgradeService;
        private readonly ICardService _cardService;

        public RegionController(
            ApplicationDbContext context, 
            UserManager<User> userManager, 
            IResourceService resourcesService, 
            IStructureUpgradeService structureUpgradeService,
            ICardService cardService)
        {
            _context = context;
            _userManager = userManager;
            _resourcesService = resourcesService;
            _structureUpgradeService = structureUpgradeService;
            _cardService = cardService;
        }
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
                .Include(r => r.RegionResources)
                    .ThenInclude(rr => rr.Resource)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (region == null)
            {
                return NotFound();
            }

            var structures = await _context.Structures.ToListAsync();
            var regionStructures = region.RegionStructures.ToList();

            var viewModel = new RegionViewModel
            {
                Region = region,
                Structures = structures,
                RegionStructures = regionStructures
            };

            return View(viewModel);
        }

        public async Task<IActionResult> BuildOrUpgradeStructure(int regionId, int structureId)
        {
            var success = await _structureUpgradeService.BuildOrUpgradeStructureAsync(regionId, structureId);
            if (!success)
                TempData["ErrorMessage"] = "No hay recursos suficientes para construir o mejorar esta estructura.";

            TempData["ToastMessage"] = "La estructura ha iniciado su construcción.";
            return RedirectToAction(nameof(Detail), new { id = regionId });
        }
    }
}
