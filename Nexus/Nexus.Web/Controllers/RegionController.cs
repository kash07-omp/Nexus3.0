using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus.Infrastructure.Data;
using Nexus.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Nexus.Web.Models;
using Nexus.Infrastructure.Services.Interfaces;
using System.Drawing;
using System.Linq.Expressions;
using Nexus.Infrastructure.Services;

namespace Nexus.Web.Controllers
{
    public class RegionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IResourceService _resourcesService;
        private readonly IStructureUpgradeService _structureUpgradeService;
        private readonly ICardService _cardService;
        private readonly IResourceCostCalculator _resourceCostCalculatorService;

        public RegionController(
            ApplicationDbContext context, 
            UserManager<User> userManager, 
            IResourceService resourcesService, 
            IStructureUpgradeService structureUpgradeService,
            ICardService cardService,
            IResourceCostCalculator resourceCostCalculatorService)
        {
            _context = context;
            _userManager = userManager;
            _resourcesService = resourcesService;
            _structureUpgradeService = structureUpgradeService;
            _cardService = cardService;
            _resourceCostCalculatorService = resourceCostCalculatorService;
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
                return NotFound();

            var user = await _userManager.GetUserAsync(User);

            var allResources = await _context.Resources.ToListAsync();
            foreach (var resource in allResources)
            {
                // Skip energy for the general resource list. TODO: Use enum
                if (resource.Id == 7)
                    continue;

                if (!region.RegionResources.Any(rr => rr.ResourceId == resource.Id))
                {
                    region.RegionResources.Add(new RegionResource
                    {
                        ResourceId = resource.Id,
                        Quantity = 0,
                        Resource = resource
                    });
                }
            }

            var allStructures = await _context.Structures.ToListAsync();
            foreach (var structure in allStructures)
            {
                if (!region.RegionStructures.Any(rs => rs.StructureId == structure.Id))
                {
                    region.RegionStructures.Add(new RegionStructure
                    {
                        StructureId = structure.Id,
                        Level = 0,
                        Structure = structure
                    });
                }
            }

            var governorCards = await _context.Cards
                .Where(c => c.Users.Any(u => u.Id == user.Id) && c.CardType == ECardType.Governor)
                .ToListAsync();

            var viewModel = new RegionViewModel
            {
                Region = region,
                Structures = allStructures,
                RegionStructures = region.RegionStructures.ToList(),
                GovernorCards = governorCards
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetCityPartialView(int regionId)
        {
            await _resourcesService.UpdateRegionResourcesAsync(regionId);
            await _structureUpgradeService.ProcessCompletedUpgradesAsync(regionId);

            var region = await _context.Regions
                .Include(r => r.Planet)
                .Include(r => r.RegionStructures)
                    .ThenInclude(rs => rs.Structure)
                .Include(r => r.RegionResources)
                    .ThenInclude(rr => rr.Resource)
                .FirstOrDefaultAsync(r => r.Id == regionId);

            if (region == null)
                return NotFound();

            var user = await _userManager.GetUserAsync(User);

            // Asegurarnos de que todas las estructuras y recursos estén presentes en la región
            var allResources = await _context.Resources.ToListAsync();
            foreach (var resource in allResources)
            {
                if (!region.RegionResources.Any(rr => rr.ResourceId == resource.Id))
                {
                    region.RegionResources.Add(new RegionResource
                    {
                        ResourceId = resource.Id,
                        Quantity = 0,
                        Resource = resource
                    });
                }
            }

            var allStructures = await _context.Structures.ToListAsync();
            foreach (var structure in allStructures)
            {
                if (!region.RegionStructures.Any(rs => rs.StructureId == structure.Id))
                {
                    region.RegionStructures.Add(new RegionStructure
                    {
                        StructureId = structure.Id,
                        Level = 0,
                        Structure = structure
                    });
                }
            }

            var governorCards = await _context.Cards
                .Where(c => c.Users.Any(u => u.Id == user.Id) && c.CardType == ECardType.Governor)
                .ToListAsync();

            var viewModel = new RegionViewModel
            {
                Region = region,
                Structures = allStructures,
                RegionStructures = region.RegionStructures.ToList(),
                GovernorCards = governorCards
            };

            return PartialView("_RegionDetailCityPartialView", viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetBarracksPartialView(int regionId)
        {
            var region = await _context.Regions
                .Include(r => r.Planet)
                .FirstOrDefaultAsync(r => r.Id == regionId);

            if (region == null)
                return NotFound();

            var user = await _userManager.GetUserAsync(User);

            // Si en el futuro necesitas más datos, puedes agregarlos aquí

            var viewModel = new RegionViewModel
            {
                Region = region
                // Puedes agregar más propiedades si es necesario
            };

            return PartialView("_RegionDetailBarracksPartialView", viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetSpaceportPartialView(int regionId, int? fleetId = null)
        {
            var userId = _userManager.GetUserId(User);

            // Obtener la región y asegurarse de que pertenece al usuario actual
            var region = await _context.Regions
                .Include(r => r.Planet)
                .FirstOrDefaultAsync(r => r.Id == regionId && r.UserId == userId);

            if (region == null)
                return NotFound();

            // Obtener todas las flotas en esta región
            var fleetsInRegion = await _context.Fleets
                .Include(f => f.FleetShips)
                    .ThenInclude(fs => fs.Ship)
                .Where(f => f.UserId == userId
                    && f.CoordinateX == region.Planet.CoordinateX
                    && f.CoordinateY == region.Planet.CoordinateY)
                .ToListAsync();

            // Obtener todas las naves disponibles
            var allShips = await _context.Ships.ToListAsync();

            // Seleccionar la flota activa
            Fleet selectedFleet = null;
            if (fleetsInRegion.Any())
            {
                if (fleetId.HasValue)
                {
                    selectedFleet = fleetsInRegion.FirstOrDefault(f => f.Id == fleetId.Value);
                }
                else
                {
                    selectedFleet = fleetsInRegion.First(); // Seleccionar la primera flota por defecto
                }
            }

            // Crear el modelo de vista
            var viewModel = new SpaceportViewModel
            {
                Region = region,
                Fleets = fleetsInRegion,
                Ships = allShips,
                SelectedFleet = selectedFleet
            };

            return PartialView("_RegionDetailSpaceportPartialView", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFleet([FromBody] CreateFleetRequest request)
        {
            var userId = _userManager.GetUserId(User);

            var region = await _context.Regions
                .Include(r => r.Planet)
                .FirstOrDefaultAsync(r => r.Id == request.RegionId && r.UserId == userId);

            if (region == null)
                return Json(new { success = false, message = "Región no encontrada." });

            var newFleet = new Fleet
            {
                Name = request.FleetName,
                UserId = userId,
                CoordinateX = region.Planet.CoordinateX,
                CoordinateY = region.Planet.CoordinateY,
                SolarSystemId = region.Planet.SolarSystemId
            };

            _context.Fleets.Add(newFleet);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        // Clase para recibir los datos del cliente
        public class CreateFleetRequest
        {
            public int RegionId { get; set; }
            public string FleetName { get; set; }
        }



        [HttpPost]
        [Route("region/{id:int}/openstructuredialog")]
        public async Task<IActionResult> OpenStructureDialog(int id, [FromBody] int structureId)
        {
            if (id <= 0 || structureId <= 0)
                return BadRequest("El ID de la región y el ID de la estructura deben ser mayores que cero.");

            var region = await _context.Regions.FindAsync(id);
            if (region == null)
                return NotFound();

            var regionStructure = await _context.RegionStructures
                .Include(rs => rs.Structure)
                    .ThenInclude(s => s.Mine)
                .FirstOrDefaultAsync(rs => rs.StructureId == structureId && rs.RegionId == id);

            if (regionStructure == null)
            {
                var structure = await _context.Structures.Include(s => s.Mine).FirstOrDefaultAsync(s => s.Id == structureId);
                if (structure == null)
                    return NotFound();

                regionStructure = new RegionStructure
                {
                    StructureId = structureId,
                    Structure = structure,
                    Region = region,
                    RegionId = id,
                    Level = 0
                };
            }

            int gainPerHour = 0;
            if (regionStructure.Structure.Mine != null)
            {
                gainPerHour = _resourcesService.CalculateMineGainPerHour(regionStructure, regionStructure.Level, region.GovernorCard);
            }
            int gainPerMinute = gainPerHour / 60;
            int gainPerSecond = gainPerHour / 3600;
            int gainPerDay = gainPerHour * 24;
            int gainPerWeek = gainPerDay * 7;

            int totalCost = _resourceCostCalculatorService.GetTotalCost(regionStructure.GetUpgradeCosts());
            int upgradeSeconds = await _structureUpgradeService.GetUpgradeSeconds(regionStructure, totalCost);
            TimeSpan upgradeTime = TimeSpan.FromSeconds(upgradeSeconds);

            string upgradeTimeText = FormatUpgradeTime(upgradeTime);

            var vm = new RegionStructureDialog
            {
                Region = region,
                RegionStructure = regionStructure,
                ResourceGainPerSecond = gainPerSecond,
                ResourceGainPerMinute = gainPerMinute,
                ResourceGainPerHour = gainPerHour,
                ResourceGainPerDay = gainPerDay,
                ResourceGainPerWeek = gainPerWeek,
                UpgradeTimeText = upgradeTimeText,
            };

            return PartialView("~/Views/Region/_RegionStructurePartialView.cshtml", vm);
        }

        [HttpPost]
        public async Task<IActionResult> BuildOrUpgradeStructure(int regionId, int structureId)
        {
            var success = await _structureUpgradeService.BuildOrUpgradeStructureAsync(regionId, structureId);
            if (!success)
                TempData["ErrorMessage"] = "No hay recursos suficientes para construir o mejorar esta estructura.";

            TempData["ToastMessage"] = "La estructura ha iniciado su construcción.";
            return RedirectToAction(nameof(Detail), new { id = regionId });
        }

        [HttpPost]
        public async Task<IActionResult> SetGovernor(int regionId, int cardId)
        {
            var user = await _userManager.GetUserAsync(User);

            var result = await _cardService.SetRegionGovernor(regionId, cardId, user.Id);
            if (result.Success)
                return Json(new { success = true });

            return Json(new { success = false, message = result.ErrorMessage });
        }

        private string FormatUpgradeTime(TimeSpan upgradeTime)
        {
            if (upgradeTime.TotalDays >= 1)
            {
                int days = (int)upgradeTime.TotalDays;
                return $"{days} días, {upgradeTime.Hours} horas, {upgradeTime.Minutes} minutos y {upgradeTime.Seconds} segundos";
            }
            else
            {
                return $"{upgradeTime.Hours} horas, {upgradeTime.Minutes} minutos y {upgradeTime.Seconds} segundos";
            }
        }
    }
}
