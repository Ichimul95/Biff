﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiffFestival.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         return View();
      }
      [HttpPost]
      public JsonResult KeepSessionAlive()
      {
         return new JsonResult { Data = "Success" };
      }
   }
}