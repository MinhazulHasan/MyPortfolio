using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
