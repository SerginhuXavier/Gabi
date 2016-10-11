using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Admin.Models;

namespace Admin.Controllers
{
    public class TrabalhosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Trabalhos
        public ActionResult Index()
        {
            return View(db.Trabalhos.ToList());
        }

        // GET: Trabalhos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabalhos trabalhos = db.Trabalhos.Find(id);
            if (trabalhos == null)
            {
                return HttpNotFound();
            }
            return View(trabalhos);
        }

        // GET: Trabalhos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trabalhos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,idCategoria,nome")] Trabalhos trabalhos)
        {
            if (ModelState.IsValid)
            {
                db.Trabalhos.Add(trabalhos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trabalhos);
        }

        // GET: Trabalhos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabalhos trabalhos = db.Trabalhos.Find(id);
            if (trabalhos == null)
            {
                return HttpNotFound();
            }
            return View(trabalhos);
        }

        // POST: Trabalhos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,idCategoria,nome")] Trabalhos trabalhos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trabalhos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trabalhos);
        }

        // GET: Trabalhos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabalhos trabalhos = db.Trabalhos.Find(id);
            if (trabalhos == null)
            {
                return HttpNotFound();
            }
            return View(trabalhos);
        }

        // POST: Trabalhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trabalhos trabalhos = db.Trabalhos.Find(id);
            db.Trabalhos.Remove(trabalhos);
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