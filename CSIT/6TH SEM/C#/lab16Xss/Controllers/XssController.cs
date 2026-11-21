using Microsoft.AspNetCore.Mvc;

namespace lab16Xss.Controllers
{
    public class XssController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string comment)
        {
            ViewBag.UserComment = comment;
            return View("Result");
        }

    }
}
