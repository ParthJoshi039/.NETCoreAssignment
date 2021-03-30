using EmployeeManagement.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //if(HttpContext.Session.GetString("Token") == null )
            //{
            //    return RedirectToAction("Login", "Login");
            //}
            //ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return RedirectToAction("Login","Login");
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
        public IActionResult Error()
        {
            return View();
        }
    }
}
