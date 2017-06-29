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
    public class SandwichesController : Controller
    {
        private KingslandContext db = new KingslandContext();

        public virtual ICollection<Ingredient> Ingredients { get; set; }

        // GET: Sandwiches
        public ActionResult Index()
        {
            return View(db.Sandwiches.ToList());
        }

        // GET: Sandwiches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sandwich sandwich = db.Sandwiches.Find(id);
            if (sandwich == null)
            {
                return HttpNotFound();
            }
            return View(sandwich);
        }

        // GET: Sandwiches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sandwiches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SandwichID,SandwichName,SandwichCost")] Sandwich sandwich)
        {
            if (ModelState.IsValid)
            {
                db.Sandwiches.Add(sandwich);
                db.SaveChanges();
                return RedirectToAction("AddIngredients", new { sandwichID = sandwich.SandwichID });
            }

            return View(sandwich);
        }

        // GET: Sandwich/AddIngredients
        public ActionResult AddIngredients()
        {
            return View(db.Ingredients.ToList());
        }

        // POST: Sandwich/AddIngredients
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddIngredients([Bind(Include = "ID,Name,Price,Meal,Ingredients")] Sandwich sandwich)
        {
            var sandwichID = Request.QueryString["sandwichID"];
            if (ModelState.IsValid)
            {

            }
            return View(sandwich.Ingredients);
        }

        // GET: Sandwiches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sandwich sandwich = db.Sandwiches.Find(id);
            if (sandwich == null)
            {
                return HttpNotFound();
            }
            return View(sandwich);
        }

        // POST: Sandwiches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SandwichID,SandwichName,SandwichCost")] Sandwich sandwich)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sandwich).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sandwich);
        }

        // GET: Sandwiches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sandwich sandwich = db.Sandwiches.Find(id);
            if (sandwich == null)
            {
                return HttpNotFound();
            }
            return View(sandwich);
        }

        // POST: Sandwiches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sandwich sandwich = db.Sandwiches.Find(id);
            db.Sandwiches.Remove(sandwich);
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
