using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Help.Controllers
{
    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
