﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiffFestival.Controllers
{
    public class KeepAliveController : Controller
    {
      public ActionResult Index()
      {
         return Content("I am alive!");
      }
   }
}