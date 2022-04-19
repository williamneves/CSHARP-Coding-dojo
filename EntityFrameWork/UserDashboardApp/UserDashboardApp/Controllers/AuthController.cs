using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserDashboardApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace UserDashboardApp.Controllers
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

        [HttpPost("LoginUser")]
        public IActionResult LoginUser(LoginUser userSubmission)
        {
            // Check initial ModelState
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.Email);

                if (userInDb == null)
                {
                    // If no user exists with provided email
                    ModelState.AddModelError("Email", "*User not found");
                    TempData["LoginError"] = "emailnotfound";
                    return View("Login");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);

                if (result == 0)
                {
                    // password does not match
                    ModelState.AddModelError("Password", "*Password is incorrect");
                    TempData["LoginError"] = "passwordincorrect";
                    return View("Login");
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                Console.WriteLine("User Login Successful");

                ViewBag.UserLoggedIn = userInDb;

                return RedirectToAction("Dashboard", "Home");
            }

            // Not Valid ModelState
            TempData["LoginError"] = "invalidform";
            return View("Login");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            TempData["Logout"] = "Logout Successful";
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet("CreateUser")]
        public IActionResult CreateNewUser()
        {
            var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));

            ViewBag.UserLoggedIn = userInDb;
            return View();
        }
        
        [HttpGet("userprofile/{UserId}")]
        public IActionResult UserProfile(int UserId)
        {
            User userProfile = dbContext.Users.FirstOrDefault(u => u.UserId == UserId);
            ViewBag.UserProfile = userProfile;
                
            User userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserLoggedIn = userInDb;
            
            // Comments for User
            List<Message> messages = dbContext.Messages
                .Where(c => c.TargetUserId == UserId)
                .ToList();
            ViewBag.Messages = messages;
            
            return View();
        }
        
        [HttpGet("editprofile/{UserId}")]
        public IActionResult EditProfile(int UserId)
        {
            User userProfile = dbContext.Users.FirstOrDefault(u => u.UserId == UserId);
            ViewBag.UserProfile = userProfile;
                
            User userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserLoggedIn = userInDb;
                
            return View();
        }
        [HttpPost("EditProfileDescription")]
        public IActionResult EditProfileDescription(EditUserDescription user)
        {
            User userProfile = dbContext.Users.FirstOrDefault(u => u.UserId == user.UserId);
            userProfile.Description = user.Description;
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }
        [HttpPost("EditUserPassword")]
        public IActionResult EditUserPassword(EditUserPassword user)
        {
            User userProfile = dbContext.Users.FirstOrDefault(u => u.UserId == user.UserId);
            var hasher = new PasswordHasher<User>();
            var result = hasher.VerifyHashedPassword(userProfile, userProfile.Password, user.Password);
            if (result == 0)
            {
                ModelState.AddModelError("Password", "*Password is incorrect");
                return View("EditProfile");
            }

            userProfile.Password = user.Password;
            userProfile.Password = hasher.HashPassword(userProfile, user.Password);
            
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }
        
        [HttpPost("EditUserInformation")]
        public IActionResult EditUserInformation(EditUserInformation user)
        {
            User userProfile = dbContext.Users.FirstOrDefault(u => u.UserId == user.UserId);
            userProfile.FirstName = user.FirstName;
            userProfile.LastName = user.LastName;
            userProfile.Email = user.Email;
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }
        

        [HttpGet("registermodal")]
        public IActionResult RegisterModal()
        {
            return PartialView("LoginRegisterModel");
        }
        

        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser(User newUser)
        {
            // Check initial ModelState
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                if (dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    // Email already exists
                    TempData["LoginError"] = "emailinuse";
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Register");
                }
                
                // Setting first user as Admin
                if (dbContext.Users.Count() == 0)
                {
                    newUser.UserLevel = "Admin";
                }

                // Initialize hasher object
                PasswordHasher<User> Hasher = new PasswordHasher<User>();

                // Hash password
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

                // Save new user to database
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                
                // Check if logged user is admin
                User userInDb = dbContext.Users.FirstOrDefault(u => u.UserId ==  HttpContext.Session.GetInt32("UserId"));
                if (userInDb.UserLevel == "Admin")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Save new user to session
                    HttpContext.Session.SetInt32("UserId", newUser.UserId);

                    ViewBag.UserLoggedIn = newUser;

                    return RedirectToAction("Index", "Home");
                }
            }
            
            

            // Not Valid ModelState
            TempData["LoginError"] = "modelstateinvalid";
            return View("Register");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}