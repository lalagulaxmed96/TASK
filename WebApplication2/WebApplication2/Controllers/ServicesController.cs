﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
