using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RaveSpeak.Helpers;
using RaveSpeak.Models;

namespace RaveSpeak.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FleschKincaidGradeLevel = "X";
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(TextModel model)
        {
            var textStatisticsHelper = new TextStatisticsHelper(model.UserText);
            ViewBag.FleschKincaidGradeLevel = textStatisticsHelper.FleschKincaidGradeLevel;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
