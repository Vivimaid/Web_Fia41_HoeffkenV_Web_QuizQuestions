﻿using Microsoft.AspNetCore.Mvc;

namespace Web_Fia41_HoeffkenV_Web_QuizQuestions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
