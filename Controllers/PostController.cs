﻿using Microsoft.AspNetCore.Mvc;

namespace ChatForum.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
