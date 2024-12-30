using Microsoft.AspNetCore.Mvc;

namespace AspNetCore241230.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }

        public IActionResult About ()
        {
            ViewData["Message"] = "ASP.NET Core MVC 예제입니다.";
            return View();
        }
    }
}
