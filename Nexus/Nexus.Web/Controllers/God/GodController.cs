using Microsoft.AspNetCore.Mvc;

namespace Nexus.Web.Controllers.God
{
    public class GodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
