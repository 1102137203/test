﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        public ActionResult Index()
        {
            return View();
        }
    }
}