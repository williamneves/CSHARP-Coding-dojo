using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace ChefsDishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext dbContext;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        public IActionResult Index()
        {
            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));

            ViewBag.UserLoggedIn = userInDb;
            return View();
        }

        [HttpGet("welcome")]
        public IActionResult Welcome()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }
            
            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserLoggedIn = userInDb;

            return View();
        }
        [HttpGet("chefs/new")]
        public IActionResult NewChef()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }
            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserLoggedIn = userInDb;
            return View();
        }

        [HttpPost("CreateChef")]
        public IActionResult CreateChef(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Chefs.Any(c => c.FirstName == newChef.FirstName && c.LastName == newChef.LastName))
                {
                    ModelState.AddModelError("FirstName", "Chef already exists");
                    return View("NewChef");
                }
                else
                {
                    dbContext.Add(newChef);
                    dbContext.SaveChanges();
                    return RedirectToAction("Chefs");
                }
            }
            else
            {
                return View("NewChef");
            }
        }

        [HttpGet("chefs")]
        public IActionResult Chefs()
        {
            // if (HttpContext.Session.GetInt32("UserId") == null)
            // {
            //     TempData["AuthError"] = "You must be logged in to view this page";
            //     return RedirectToAction("Index");
            // }

            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));

            ViewBag.UserLoggedIn = userInDb;

            var allChefs = dbContext.Chefs.Include(c => c.CreatedDishes).ToList();
            ViewBag.AllChefs = allChefs;

            return View();
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }

            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserLoggedIn = userInDb;

            List<Chef> allChefs = dbContext.Chefs.Include(c => c.CreatedDishes).ToList();
            ViewBag.AllChefs = allChefs;

            return View();
        }
        [HttpPost("CreateDish")]
        public IActionResult CreateDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                if (HttpContext.Session.GetInt32("UserId") == null)
                {
                    TempData["AuthError"] = "You must be logged in to view this page";
                    return RedirectToAction("Index");
                }

                var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));

                Console.WriteLine("User Logged In: ", HttpContext.Session.GetInt32("UserId"));

                ViewBag.UserLoggedIn = userInDb;

                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {
                List<Chef> allChefs = dbContext.Chefs.Include(c => c.CreatedDishes).ToList();
                ViewBag.AllChefs = allChefs;
                return View("NewDish");
            }
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            // if (HttpContext.Session.GetInt32("UserId") == null)
            // {
            //     TempData["AuthError"] = "You must be logged in to view this page";
            //     return RedirectToAction("Index");
            // }

            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));

            ViewBag.UserLoggedIn = userInDb;

            var allDishes = dbContext.Dishes.Include(d => d.DishChef).ToList();
            ViewBag.AllDishes = allDishes;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
