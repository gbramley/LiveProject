using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KingslandRedux.Data;
using KingslandRedux.Models;

namespace KingslandRedux.Controllers
{
    public class BreadsController : Controller
    {
        private KingslandContext db = new KingslandContext();

        // GET: Breads
        public ActionResult Index()
        {
            return View(db.Breads.ToList());
        }

        // GET: Breads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bread bread = db.Breads.Find(id);
            if (bread == null)
            {
                return HttpNotFound();
            }
            return View(bread);
        }

        // GET: Breads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Breads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BreadID,BreadName,BreadCost")] Bread bread)
        {
            if (ModelState.IsValid)
            {
                db.Breads.Add(bread);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bread);
        }

        // GET: Breads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bread bread = db.Breads.Find(id);
            if (bread == null)
            {
                return HttpNotFound();
            }
            return View(bread);
        }

        // POST: Breads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BreadID,BreadName,BreadCost")] Bread bread)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bread).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bread);
        }

        // GET: Breads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bread bread = db.Breads.Find(id);
            if (bread == null)
            {
                return HttpNotFound();
            }
            return View(bread);
        }

        // POST: Breads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bread bread = db.Breads.Find(id);
            db.Breads.Remove(bread);
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
