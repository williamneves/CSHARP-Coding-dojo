using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojo_Survey_Validation.Models;

namespace Dojo_Survey_Validation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("formsubmit")]
        public IActionResult  FormSubmit(User user)
        {

            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", user);
            }
            else
            {
                return View("Index");
            }

        }

        [HttpGet("result")]

        public IActionResult Result(User user)
        {
            // ViewBag.Name = Name;
            // ViewBag.DojoLocation = DojoLocation;
            // ViewBag.FavLang = FavLang;
            // ViewBag.Comment = Comment;
            
            return View("Result", user);
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
