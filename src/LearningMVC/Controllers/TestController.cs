﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Hello World";
        }
    }
}