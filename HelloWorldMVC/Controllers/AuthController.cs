using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloWorldMVC.Models;

namespace HelloWorldMVC.Controllers
{
    public class Auth : Controller
    {
        [HttpPost("user/create")]
        public IActionResult Create(User user)
        {

            if(ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("SomeAction");
            }

            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("NewUser");
            }
        }
}
