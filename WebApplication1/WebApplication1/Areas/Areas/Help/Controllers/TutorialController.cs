using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Areas.Help.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
