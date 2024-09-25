using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus.Infrastructure.Data;
using Nexus.Domain.Entities;
using Nexus.Web.Models;
using Microsoft.AspNet.Identity;
using Nexus.Web.Services.UserRegister;

namespace Nexus.Web.Controllers
{
    public class SolarSystemController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRegisterService _userRegisterService;

        public SolarSystemController(
            ApplicationDbContext context,
            IUserRegisterService userRegisterService)
        {
            _context = context;
            _userRegisterService = userRegisterService;
        }

        public async Task<IActionResult> Detail(int id)
        {
            var solarSystem = await _context.SolarSystems
                .Include(ss => ss.Planets)
                .Include(ss => ss.AsteroidFields)
                .Include(ss => ss.JumpGates)
                .FirstOrDefaultAsync(ss => ss.Id == id);

            if (solarSystem == null)
            {
                return NotFound();
            }

            var viewModel = new SolarSystemViewModel
            {
                SolarSystem = solarSystem
            };

            return View(viewModel);
        }
    }
}
