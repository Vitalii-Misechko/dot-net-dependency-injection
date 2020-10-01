﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.ConsoleDomain;

namespace WebApplication.Controllers
{
    public class HomeController : Controller {

        private readonly IOutputEnvFormatter _outputEnvFormatter;

        public HomeController( IOutputEnvFormatter outputEnvFormatter ) {
            _outputEnvFormatter = outputEnvFormatter;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _outputEnvFormatter.FormatLine( "Hello World!" );

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message =  "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}