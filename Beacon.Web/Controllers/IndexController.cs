﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Beacon.Web.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}