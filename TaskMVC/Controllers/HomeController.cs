﻿using Microsoft.AspNetCore.Mvc;

namespace TaskMVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}