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
    public class vadKhoasController : Controller
    {
        private VadK22CNT2Lesson10DbEntities3 db = new VadK22CNT2Lesson10DbEntities3();

        // GET: vadKhoas
        public ActionResult VADKhoa()
        {
            return View(db.vadKhoas.ToList());
        }

        // GET: vadKhoas/Details/5
        public ActionResult VADDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadKhoa vadKhoa = db.vadKhoas.Find(id);
            if (vadKhoa == null)
            {
                return HttpNotFound();
            }
            return View(vadKhoa);
        }

        // GET: vadKhoas/Create
        public ActionResult VADCreate()
        {
            return View();
        }

        // POST: vadKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VADCreate([Bind(Include = "vadMaKH,vadTenKH")] vadKhoa vadKhoa)
        {
            if (ModelState.IsValid)
            {
                db.vadKhoas.Add(vadKhoa);
                db.SaveChanges();
                return RedirectToAction("VADKhoa");
            }

            return View(vadKhoa);
        }

        // GET: vadKhoas/Edit/5
        public ActionResult VADEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadKhoa vadKhoa = db.vadKhoas.Find(id);
            if (vadKhoa == null)
            {
                return HttpNotFound();
            }
            return View(vadKhoa);
        }

        // POST: vadKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VADEdit([Bind(Include = "vadMaKH,vadTenKH")] vadKhoa vadKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vadKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("VadKhoa");
            }
            return View(vadKhoa);
        }

        // GET: vadKhoas/Delete/5
        public ActionResult VADDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadKhoa vadKhoa = db.vadKhoas.Find(id);
            if (vadKhoa == null)
            {
                return HttpNotFound();
            }
            return View(vadKhoa);
        }

        // POST: vadKhoas/Delete/5
        [HttpPost, ActionName("VADDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            vadKhoa vadKhoa = db.vadKhoas.Find(id);
            db.vadKhoas.Remove(vadKhoa);
            db.SaveChanges();
            return RedirectToAction("VADKhoa");
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
