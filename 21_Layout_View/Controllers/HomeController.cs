﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21_Layout_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        //example for section view -> go on contact.cshtml & _Layout.cshtml pages
        public ViewResult Contact()
        {
            return View();
        }
    }
}