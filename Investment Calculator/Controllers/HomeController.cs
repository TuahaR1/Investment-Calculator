using Investment_Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Investment_Calculator.Controllers
{
    public class HomeController : Controller
    {
        // Action Method
        // Return data type us IActionResult
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else 
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}
