﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Alba.v2.Controllers
{
    public class LogController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }
    }
}