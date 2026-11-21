using System.Diagnostics;
using lab19cookies.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab19cookies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // read cookie from Request object
            string userName = Request.Cookies["UserName"];
            return View("Index", userName);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string userName = form["userName"].ToString();
            // set the key value in Cookie
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("UserName", userName, option);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveCookie()
        {
            // Delete the cookie
            Response.Cookies.Delete("UserName");
            return View("Index");
        }

    }
}
