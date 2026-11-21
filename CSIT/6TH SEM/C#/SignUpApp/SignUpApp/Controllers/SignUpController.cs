using Microsoft.AspNetCore.Mvc;
using SignUpApp.Models;

namespace SignUpApp.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SignUp model)
        {
            return View("Result", model);
        }
    }
}