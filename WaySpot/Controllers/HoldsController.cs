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
    public class HoldsController : Controller
    {
        private WaySpotContext db = new WaySpotContext();

        // GET: Holds
        public ActionResult Index()
        {
            return View(db.Holds.ToList());
        }

        // GET: Hold for date
        [HttpGet]
        public ActionResult GetHoldDate()
        {
            var today = DateTime.Now;
            var holdObjects = db.Holds.ToList().Where(e => e.HoldDateTime.Date == today.Date);

            return Json(new { data = holdObjects }, JsonRequestBehavior.AllowGet);
        }

        // GET: Holds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hold hold = db.Holds.Find(id);
            if (hold == null)
            {
                return HttpNotFound();
            }
            return View(hold);
        }

        // GET: Holds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Holds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HoldID,Person,HoldDateTime,Comments")] Hold hold)
        {
            if (ModelState.IsValid)
            {
                db.Holds.Add(hold);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hold);
        }

        // GET: Holds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hold hold = db.Holds.Find(id);
            if (hold == null)
            {
                return HttpNotFound();
            }
            return View(hold);
        }

        // POST: Holds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HoldID,Person,HoldDateTime,Comments")] Hold hold)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hold).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hold);
        }

        // GET: Holds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hold hold = db.Holds.Find(id);
            if (hold == null)
            {
                return HttpNotFound();
            }
            return View(hold);
        }

        // POST: Holds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hold hold = db.Holds.Find(id);
            db.Holds.Remove(hold);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
