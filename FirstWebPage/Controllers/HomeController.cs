using System;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebPage.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]

        public String Index()
        {
            return "This is my Index!";
        }

        [HttpGet]
        [Route("contact")]

        public string Contact()
        {
            return "This is my Contact Page!";
        }

        [HttpGet]
        [Route("profile")]

        public string profile()
        {
            return "This is my Profile page Page!";
        }
    }
}
