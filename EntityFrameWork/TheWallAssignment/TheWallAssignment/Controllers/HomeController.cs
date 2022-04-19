using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheWallAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace TheWallAssignment.Controllers
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
            // Catch user's session in the database
            var userInDb = dbContext.Users
                .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            
            // Catch all messages and comments in the database
            var allMessages = dbContext.Messages
                .Include(u => u.User)
                .Include(c => c.Comments)
                .OrderByDescending(date => date.CreatedAt)
                .ToList();
            
            // ViewBags
            ViewBag.UserLoggedIn = userInDb;
            ViewBag.AllMessages = allMessages;
            return View();
        }
        
        [HttpPost("postMessage")]
        public IActionResult PostMessage(Message newMessage)
        {
            // Catch user's session in the database
            var userInDb = dbContext.Users
                .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            
            // Create new message
            newMessage.UserId = userInDb.UserId;
            dbContext.Add(newMessage);
            dbContext.SaveChanges();
            
            // Catch all messages and comments in the database
            var allMessages = dbContext.Messages
                .Include(u => u.User)
                .Include(c => c.Comments)
                .OrderByDescending(date => date.CreatedAt)
                .ToList();
            
            // ViewBags
            ViewBag.UserLoggedIn = userInDb;
            ViewBag.AllMessages = allMessages;
            return View("Index");
        }
        
        [HttpGet("message/{messageId}")]
        public IActionResult IndividualMessage(int messageId)
        {
            // Catch user's session in the database
            var userInDb = dbContext.Users
                .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            
            // Catch the message and comments in the database
            var message = dbContext.Messages
                .Include(u => u.User)
                .Include(c => c.Comments)
                .FirstOrDefault(m => m.MessageId == messageId);

            // ViewBags
            ViewBag.UserLoggedIn = userInDb;
            ViewBag.Message = message;
            return View();
        }
        
        [HttpPost("postComment")]
        public IActionResult PostComment(Comment newComment)
        {
            // Catch user's session in the database
            var userInDb = dbContext.Users
                .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            
            // Create new comment
            newComment.UserId = userInDb.UserId;
            dbContext.Add(newComment);
            dbContext.SaveChanges();
            
            // Catch the message and comments in the database
            var message = dbContext.Messages
                .Include(u => u.User)
                .Include(c => c.Comments)
                .FirstOrDefault(m => m.MessageId == newComment.MessageId);

            // ViewBags
            ViewBag.UserLoggedIn = userInDb;
            ViewBag.Message = message;
            return RedirectToAction("IndividualMessage", new {messageId = newComment.MessageId});
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}