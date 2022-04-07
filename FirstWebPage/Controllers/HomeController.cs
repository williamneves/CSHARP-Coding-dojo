using System;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebPage.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        

        public IActionResult Index()
        {
            // ViewBag.title = "Hello World!";
            return View();
        }

        [HttpPost("formsubmit")]

        public IActionResult  FormSubmit(string Name, string DojoLocation, string FavLang, string Comment)
        {

            var form = new{
                Name = Name,
                DojoLocation = DojoLocation,
                FavLang = FavLang,
                Comment = Comment
                };

            return RedirectToAction("Result", form);
        }

        [HttpGet("result")]

        public IActionResult Result(string Name, string DojoLocation, string FavLang, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.DojoLocation = DojoLocation;
            ViewBag.FavLang = FavLang;
            ViewBag.Comment = Comment;
            return View("Result");
        }
    }
}
