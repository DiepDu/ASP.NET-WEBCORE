using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webcore.Models;

namespace webcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
