using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConDisceplines.DAL;
using ConDisceplines.Models;

namespace ConDisceplines.Controllers
{
    public class DisceplinesController : Controller
    {
        private DisceplineContext db = new DisceplineContext();

        // GET: Disceplines
        public ActionResult Index()
        {
            return View(db.Disceplines.ToList());
        }

        // GET: Disceplines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discepline discepline = db.Disceplines.Find(id);
            if (discepline == null)
            {
                return HttpNotFound();
            }
            return View(discepline);
        }

        // GET: Disceplines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disceplines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NameDiscepline,Hours,Control")] Discepline discepline)
        {
            if (ModelState.IsValid)
            {
                db.Disceplines.Add(discepline);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(discepline);
        }

        // GET: Disceplines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discepline discepline = db.Disceplines.Find(id);
            if (discepline == null)
            {
                return HttpNotFound();
            }
            return View(discepline);
        }

        // POST: Disceplines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NameDiscepline,Hours,Control")] Discepline discepline)
        {
            if (ModelState.IsValid)
            {
                db.Entry(discepline).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(discepline);
        }

        // GET: Disceplines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discepline discepline = db.Disceplines.Find(id);
            if (discepline == null)
            {
                return HttpNotFound();
            }
            return View(discepline);
        }

        // POST: Disceplines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Discepline discepline = db.Disceplines.Find(id);
            db.Disceplines.Remove(discepline);
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
