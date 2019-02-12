using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        public IActionResult Calculate(Calculator calculator)
        {
            calculator.CalculateResult();

            if (calculator.RightOperand == 0 && calculator.Operator == "/")
            {
                TempData["Error"] = "Can not divide by 0";
            }
            else
            {
                Data.CalculatorHistory.Add(calculator);
            }

            return RedirectToAction("Index", calculator);
        }

        public IActionResult History()
        {
            return View(Data.CalculatorHistory);
        }

    }
}
