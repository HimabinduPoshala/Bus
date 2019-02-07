using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class QuotesController : Controller
    {
        public IActionResult Text()
        {
            return Content("This is Text View");
        }
    public IActionResult JSONView()
        {
            return Json(new {name="JSON",description = "This is second controller"});
        }
        
        public IActionResult Displayview()
        {
            return View();
        }

        public IActionResult HTML()
        {
            return Content("<html><body><h1>This is html content</h1> </body></html>","text/html");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
