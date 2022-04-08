using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojo_Survey_Validation.Models;
using Microsoft.AspNetCore.Http;

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
            return View("Result", user);
        }

        [HttpGet("generator")]
        public IActionResult Generator()
        {

            string newPassword = HttpContext.Session.GetString("password");
            int? Count = HttpContext.Session.GetInt32("Count");

            ViewBag.newPassword = newPassword;
            ViewBag.Count = Count;

            return View();
        }

        [HttpPost("randompass")]
        public IActionResult RandomPass()
        {
            int len = 10;
            string password = "";
            Random rand = new Random();
            for(int i = 0; i < len; i++)
            {
                int num = rand.Next(0, 122);
                if(num >= 97 && num <= 122)
                {
                    password += (char)num;
                }
                else if(num >= 65 && num <= 90)
                {
                    password += (char)num;
                }
                else if(num >= 48 && num <= 57)
                {
                    password += (char)num;
                }
                else
                {
                    i--;
                }
            }
            HttpContext.Session.SetString("password", password);
            if (HttpContext.Session.GetInt32("Count") == null)
            {
                HttpContext.Session.SetInt32("Count", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("Count", (int)(HttpContext.Session.GetInt32("Count") + 1));
            }

            
            Console.WriteLine($"Password: {password}");
            
            return RedirectToAction("Generator");
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
