using System.Diagnostics;
using lab18session.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab18session.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // read value from Session
            string userName = HttpContext.Session.GetString("UserName");
            return View("Index", userName);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string userName = form["userName"].ToString();

            // set the key value in Session
            HttpContext.Session.SetString("UserName", userName);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveSession()
        {
            // remove the key from Session
            HttpContext.Session.Remove("UserName");
            return View("Index");
        }

    }
}
