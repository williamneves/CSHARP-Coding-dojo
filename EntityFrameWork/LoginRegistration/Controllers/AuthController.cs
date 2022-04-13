using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginRegistration.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private MyContext dbContext;

        public AuthController(ILogger<AuthController> logger, MyContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet("registermodal")]
        public IActionResult RegisterModal()
        {
            return PartialView("LoginRegisterModel");
        }

        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser()
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Register");
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
