using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using D07_EF6_MVC_DF_02.Models;

namespace D07_EF6_MVC_DF_02.Controllers
{
    public class SubCategoriasController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: SubCategorias
        public ActionResult Index()
        {
            var subCategoria = db.SubCategoria.Include(s => s.Categories);
            return View(subCategoria.ToList());
        }

        // GET: SubCategorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCategoria.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            return View(subCategoria);
        }

        // GET: SubCategorias/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            return View();
        }

        // POST: SubCategorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubCategoriaID,CategoryID,SubCategoria1")] SubCategoria subCategoria)
        {
            if (ModelState.IsValid)
            {
                db.SubCategoria.Add(subCategoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", subCategoria.CategoryID);
            return View(subCategoria);
        }

        // GET: SubCategorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCategoria.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", subCategoria.CategoryID);
            return View(subCategoria);
        }

        // POST: SubCategorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubCategoriaID,CategoryID,SubCategoria1")] SubCategoria subCategoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subCategoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", subCategoria.CategoryID);
            return View(subCategoria);
        }

        // GET: SubCategorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCategoria.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            return View(subCategoria);
        }

        // POST: SubCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubCategoria subCategoria = db.SubCategoria.Find(id);
            db.SubCategoria.Remove(subCategoria);
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
