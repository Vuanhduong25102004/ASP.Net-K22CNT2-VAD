using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson08_VAD.Models;

namespace Lesson08_VAD.Controllers
{
    public class VadBooksController : Controller
    {
        private VadBookStore db = new VadBookStore();

        // GET: VadBooks
        public ActionResult VadIndex()
        {
            var vadBooks = db.VadBooks.Include(v => v.VadCategory);
            return View(vadBooks.ToList());
        }

        // GET: VadBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VadBook vadBook = db.VadBooks.Find(id);
            if (vadBook == null)
            {
                return HttpNotFound();
            }
            return View(vadBook);
        }

        // GET: VadBooks/Create
        public ActionResult Create()
        {
            ViewBag.VadCategoryId = new SelectList(db.VadCategories, "VadCategoryId", "VadCategoryName");
            return View();
        }

        // POST: VadBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VadBookId,VadTitle,VadAuthor,VadYear,VadPublisher,VadPicture,VadCategoryId")] VadBook vadBook)
        {
            if (ModelState.IsValid)
            {
                db.VadBooks.Add(vadBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VadCategoryId = new SelectList(db.VadCategories, "VadCategoryId", "VadCategoryName", vadBook.VadCategoryId);
            return View(vadBook);
        }

        // GET: VadBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VadBook vadBook = db.VadBooks.Find(id);
            if (vadBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.VadCategoryId = new SelectList(db.VadCategories, "VadCategoryId", "VadCategoryName", vadBook.VadCategoryId);
            return View(vadBook);
        }

        // POST: VadBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VadBookId,VadTitle,VadAuthor,VadYear,VadPublisher,VadPicture,VadCategoryId")] VadBook vadBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vadBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VadCategoryId = new SelectList(db.VadCategories, "VadCategoryId", "VadCategoryName", vadBook.VadCategoryId);
            return View(vadBook);
        }

        // GET: VadBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VadBook vadBook = db.VadBooks.Find(id);
            if (vadBook == null)
            {
                return HttpNotFound();
            }
            return View(vadBook);
        }

        // POST: VadBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VadBook vadBook = db.VadBooks.Find(id);
            db.VadBooks.Remove(vadBook);
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
