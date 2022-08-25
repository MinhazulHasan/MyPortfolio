using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
