using Microsoft.AspNetCore.Mvc;
using SimpleInterestApp.Models;

namespace SimpleInterestApp.Controllers
{
    public class InterestController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(new SimpleInterest());

        [HttpPost]
        public IActionResult Index(SimpleInterest model)
        {
            model.Result = (model.Principal * model.Rate * model.Time) / 100;
            return View(model);
        }
    }
}