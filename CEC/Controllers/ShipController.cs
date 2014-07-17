using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CEC.DAL;
using CEC.Models;

namespace CEC.Controllers
{
    public class ShipController : Controller
    {
        private CompanyContext db = new CompanyContext();

        // GET: Ship
        public ViewResult Index()
        {
            return View(db.Ships.ToList());
        }

        // GET: Ship/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ship ship = db.Ships.Find(id);
            if (ship == null)
            {
                return HttpNotFound();
            }
            return View(ship);
        }

        // GET: Ship/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ship/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Price")] Ship ship)
        {
            if (ModelState.IsValid)
            {
                db.Ships.Add(ship);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ship);
        }

        // GET: Ship/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ship ship = db.Ships.Find(id);
            if (ship == null)
            {
                return HttpNotFound();
            }
            return View(ship);
        }

        // POST: Ship/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Price")] Ship ship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ship).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ship);
        }

        // GET: Ship/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ship ship = db.Ships.Find(id);
            if (ship == null)
            {
                return HttpNotFound();
            }
            return View(ship);
        }

        // POST: Ship/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ship ship = db.Ships.Find(id);
            db.Ships.Remove(ship);
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
