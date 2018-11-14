using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PaginaDeRegistro.Models;

namespace PaginaDeRegistro.Controllers
{
    public class InteresesController : Controller
    {
        private PaginaDeRegistroContext db = new PaginaDeRegistroContext();

        // GET: Intereses
        public ActionResult Index()
        {
            return View(db.Intereses.ToList());
        }

        // GET: Intereses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intereses intereses = db.Intereses.Find(id);
            if (intereses == null)
            {
                return HttpNotFound();
            }
            return View(intereses);
        }

        // GET: Intereses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Intereses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre")] Intereses intereses)
        {
            if (ModelState.IsValid)
            {
                db.Intereses.Add(intereses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(intereses);
        }

        // GET: Intereses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intereses intereses = db.Intereses.Find(id);
            if (intereses == null)
            {
                return HttpNotFound();
            }
            return View(intereses);
        }

        // POST: Intereses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] Intereses intereses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(intereses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(intereses);
        }

        // GET: Intereses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Intereses intereses = db.Intereses.Find(id);
            if (intereses == null)
            {
                return HttpNotFound();
            }
            return View(intereses);
        }

        // POST: Intereses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Intereses intereses = db.Intereses.Find(id);
            db.Intereses.Remove(intereses);
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
