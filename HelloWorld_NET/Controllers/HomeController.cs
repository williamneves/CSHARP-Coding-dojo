using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_NET
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public string index()
        {
            return "Hello from Index";
        }

        [Route("hello")]
        [HttpGet]
        public string hello()
        {
            return "Hello from controller hello";
        }
    }
}