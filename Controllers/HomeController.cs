using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            User peep = new User();
            return View(peep);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
                else
            {
                return View("Index");
            }
        }

        [HttpGet("Success")]
        public IActionResult Success()
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
