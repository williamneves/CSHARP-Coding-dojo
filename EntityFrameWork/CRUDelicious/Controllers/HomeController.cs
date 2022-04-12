using System.Globalization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext dbContext;
    
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context,ILogger<HomeController> logger)
        {
            _logger = logger;
            dbContext = context;
        }
    
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes
                .OrderByDescending(d => d.CreatedAt)
                .ToList();

            ViewBag.AllDishes = AllDishes;
            
            return View();
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("AddNewDish")]
        public IActionResult AddNewDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                if (dbContext.Dishes.Any(d => d.Name == newDish.Name))
                {
                    ModelState.AddModelError("Name", "A Dish with this name already exists!");
                    return View("Create");
                }
                else
                {
                    dbContext.Add(newDish);
                    dbContext.SaveChanges();
                    Console.WriteLine($"\nNew dish added to DB: {newDish.Name}\n");
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View("Create");
            }
        }
        [HttpPost("UpdateDish")]
        public IActionResult UpdateDish(Dish updatedDish)
        {

            Dish actualDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == updatedDish.DishId);

            if(ModelState.IsValid)
            {
                actualDish.Chef = updatedDish.Chef;
                actualDish.Calories = updatedDish.Calories;
                actualDish.Tastiness = updatedDish.Tastiness;
                actualDish.Description = updatedDish.Description;
                actualDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                Console.WriteLine($"\nDish updated in DB: {updatedDish.Name}\n");
                return RedirectToAction("Index");
            }
            else
            {
                return View("dish/edit/{actualDish.DishId}", updatedDish);
            }
        }

        [HttpGet("dish/{dishId}")]
        public IActionResult ViewDish(int dishId)
        {
            Dish thisDish = dbContext.Dishes
                .FirstOrDefault(d => d.DishId == dishId);
            ViewBag.ThisDish = thisDish;
            return View();
        }

        [HttpGet("dish/edit/{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            Dish thisDish = dbContext.Dishes
                .FirstOrDefault(d => d.DishId == dishId);
            ViewBag.ThisDish = thisDish;
            return View();
        }   


        [HttpGet("new")]
        public IActionResult CreateData()
        {
            // // Dish FettucineAlfredo = new Dish()
            // // {
            // //     Name = "Fettucine Alfredo",
            // //     Chef = "William Neves",
            // //     Tastiness = 100,
            // //     Calories = 500,
            // //     Description = "Fettucine Alfredo is a classic Italian dish that is made with pasta, tomato sauce, and Alfredo cheese. It is often served with meatballs, or chicken breast, and often includes a side of pasta salad.",
            // //     CreatedAt = DateTime.Now,
            // //     UpdatedAt = DateTime.Now
            // // };


            // // Dish ChickenCordonBleu = new Dish()
            // // {
            // //     Name = "Chicken Cordon Bleu",
            // //     Chef = "William Neves",
            // //     Tastiness = 80,
            // //     Calories = 300,
            // //     Description = "Chicken Cordon Bleu is a dish of chicken, often with a side of French fries, that is often served with a side of French onion soup.",
            // //     CreatedAt = DateTime.Now,
            // //     UpdatedAt = DateTime.Now
            // // };

            // // Dish ChickenTikkaMasala = new Dish()
            // // {
            // //     Name = "Chicken Tikka Masala",
            // //     Chef = "Orlando Casale",
            // //     Tastiness = 950,
            // //     Calories = 1500,
            // //     Description = "Chicken Tikka Masala is a dish of chicken, often with a side of French fries, that is often served with a side of French onion soup.",
            // //     CreatedAt = DateTime.Now,
            // //     UpdatedAt = DateTime.Now
            // // };

            // // Dish ChickenTacos = new Dish()
            // // {
            // //     Name = "Chicken Tacos",
            // //     Chef = "Orlando Casale",
            // //     Tastiness = 70,
            // //     Calories = 700,
            // //     Description = "Chicken Tacos is a dish of chicken, often with a side of French fries, that is often served with a side of French onion soup.",
            // //     CreatedAt = DateTime.Now,
            // //     UpdatedAt = DateTime.Now
            // // };

            // // dbContext.Dishes.Add(FettucineAlfredo);
            // // dbContext.Dishes.Add(ChickenCordonBleu);
            // // dbContext.Dishes.Add(ChickenTikkaMasala);
            // // dbContext.Dishes.Add(ChickenTacos);
            // dbContext.SaveChanges();
            
            return RedirectToAction("Index");
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
