using System;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebPage.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]

        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("contact")]

        public ViewResult Contact()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("profile")]

        public string profile()
        {
            return "This is my Profile page Page!";
        }
    }
}
