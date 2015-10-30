using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WaySpot.DAL;
using WaySpot.Models;

namespace WaySpot.Controllers
{
    public class HomeController : Controller
    {
        private WaySpotContext db = new WaySpotContext();

        public ActionResult Index()
        {

            //return View();
            return View(db.Holds.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}