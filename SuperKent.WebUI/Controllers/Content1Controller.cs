﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperKent.WebUI.Controllers
{
    public class Content1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}