using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiffFestival.Controllers
{
    public class FestivalController : Controller
    {
        // GET: Festival
        public ActionResult Index()
        {
            return View();
        }
    }
}