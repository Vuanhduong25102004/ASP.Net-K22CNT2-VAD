using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson10_VAD.Models;

namespace Lesson10_VAD.Controllers
{
    public class vadMonHocsController : Controller
    {
        private VadK22CNT2Lesson10DbEntities3 db = new VadK22CNT2Lesson10DbEntities3();

        // GET: vadMonHocs
        public ActionResult VADMonhoc()
        {
            return View(db.vadMonHocs.ToList());
        }

        // GET: vadMonHocs/Details/5
        public ActionResult VADDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadMonHoc vadMonHoc = db.vadMonHocs.Find(id);
            if (vadMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(vadMonHoc);
        }

        // GET: vadMonHocs/Create
        public ActionResult VADCreate()
        {
            return View();
        }

        // POST: vadMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VADCreate([Bind(Include = "vadMaMH,vadTenMH,vadSotiet")] vadMonHoc vadMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.vadMonHocs.Add(vadMonHoc);
                db.SaveChanges();
                return RedirectToAction("VADMonhoc");
            }

            return View(vadMonHoc);
        }

        // GET: vadMonHocs/Edit/5
        public ActionResult VADEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadMonHoc vadMonHoc = db.vadMonHocs.Find(id);
            if (vadMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(vadMonHoc);
        }

        // POST: vadMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VADEdit([Bind(Include = "vadMaMH,vadTenMH,vadSotiet")] vadMonHoc vadMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vadMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("VADMonhoc");
            }
            return View(vadMonHoc);
        }

        // GET: vadMonHocs/Delete/5
        public ActionResult VADDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadMonHoc vadMonHoc = db.vadMonHocs.Find(id);
            if (vadMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(vadMonHoc);
        }

        // POST: vadMonHocs/Delete/5
        [HttpPost, ActionName("VADDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            vadMonHoc vadMonHoc = db.vadMonHocs.Find(id);
            db.vadMonHocs.Remove(vadMonHoc);
            db.SaveChanges();
            return RedirectToAction("VADMonhoc");
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
