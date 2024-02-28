using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {

        public IActionResult Page1()
        {

            return View();
        }
        public IActionResult Page2()
        {
            return View();
        }
        public IActionResult Page3()
        {
            return View();
        }
    }
}
