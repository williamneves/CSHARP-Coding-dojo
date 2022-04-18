using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wedding.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Wedding.Controllers
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

            Console.WriteLine("User Logged In: ", HttpContext.Session.GetInt32("UserId"));

            ViewBag.UserLoggedIn = userInDb;

            return View();
        }
        
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }
            
            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            
            Console.WriteLine("User Logged In: ", HttpContext.Session.GetInt32("UserId"));
            
            ViewBag.UserLoggedIn = userInDb;
            

            List<WeddingModel> viewBagModel = dbContext.Weddings
                .Include(w => w.Guests)
                .ThenInclude(g => g.GuestUser)
                .OrderBy(w => w.Date)
                .ToList();

            List<WeddingModel> allWeddingModel = dbContext.Weddings
                .Include(w => w.Guests)
                .ThenInclude(g => g.GuestUser)
                .OrderBy(w => w.Date)
                .ToList();

            ViewBag.ListOfWeddings = viewBagModel;

            WeddingsList listOfWeddings = new WeddingsList();
            listOfWeddings.ListOfWeddings = allWeddingModel;
            
            return View(listOfWeddings);
        }
        
        [HttpGet("NewWedding")]
        public IActionResult NewWedding()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }
            
            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            
            Console.WriteLine("User Logged In: ", HttpContext.Session.GetInt32("UserId"));

            ViewBag.UserLoggedIn = userInDb;

            return View();
        }
        
        [HttpPost("CreateWedding")]
        public IActionResult CreateWedding(Models.WeddingModel newWedding)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                dbContext.Weddings.Add(newWedding);
                dbContext.SaveChanges();
                Console.WriteLine("Wedding Created: ", newWedding.WeddingId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("NewWedding");
            }
        }
        
        [HttpGet("Join/{weddingId}")]
        public IActionResult Join(int weddingId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }

            // Join the Wedding
            dbContext.Guests.Add(new Guest { UserId = (int)HttpContext.Session.GetInt32("UserId"), WeddingId = weddingId });
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("UnJoin/{weddingId}")]
        public IActionResult UnJoin(int weddingId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }

            // Find the Guest
            var guest = dbContext.Guests.FirstOrDefault(g => g.UserId == (int)HttpContext.Session.GetInt32("UserId") && g.WeddingId == weddingId);

            // Remove guest from the Wedding
            dbContext.Guests.Remove(guest);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }
        [HttpGet("Delete/{weddingId}")]
        public IActionResult Delete(int weddingId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }

            // Find the Wedding
            var wedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            // Remove the Wedding
            dbContext.Weddings.Remove(wedding);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("Wedding/{weddingId}")]
        public IActionResult Wedding(int weddingId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["AuthError"] = "You must be logged in to view this page";
                return RedirectToAction("Index");
            }

            // Find the Wedding
            var wedding = dbContext.Weddings
                        .Include(w => w.Guests)
                        .ThenInclude(g => g.GuestUser)
                        .FirstOrDefault(w => w.WeddingId == weddingId);

            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));

            ViewBag.UserLoggedIn = userInDb;

            return View(wedding);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}   