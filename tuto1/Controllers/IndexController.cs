﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tuto1.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Hello()
        {
            return View();
        }
        // GET: Index
        public ActionResult Bonjour()
        {
            return View();
        }
    }
}