using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus.Infrastructure.Data;
using Nexus.Domain.Entities;
using Nexus.Web.Models;
using Microsoft.AspNet.Identity;
using Nexus.Web.Services.UserRegister;
using Microsoft.AspNetCore.Identity;

namespace Nexus.Web.Controllers
{
    public class SolarSystemController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRegisterService _userRegisterService;
        private readonly Microsoft.AspNetCore.Identity.UserManager<User> _userManager;

        public SolarSystemController(
            ApplicationDbContext context,
            IUserRegisterService userRegisterService,
            Microsoft.AspNetCore.Identity.UserManager<User> userManager)
        {
            _context = context;
            _userRegisterService = userRegisterService;
            _userManager = userManager;
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
    }
}
