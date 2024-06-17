using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson09_VAD.Models;

namespace Lesson09_VAD.Controllers
{
    public class VadKhoasController : Controller
    {
        private VadK22CNT2Lesson09DbEntities db = new VadK22CNT2Lesson09DbEntities();

        // GET: VadKhoas
        public ActionResult VadIndex()
        {
            return View(db.vadKhoas.ToList());
        }

        // GET: VadKhoas/Details/5
        public ActionResult VadDetails(string id)
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

        // GET: VadKhoas/Create
        public ActionResult VadCreate()
        {
            return View();
        }

        // POST: VadKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VadCreate([Bind(Include = "VadMaKH,VadTenKH,VadTrangThai")] vadKhoa vadKhoa)
        {
            if (ModelState.IsValid)
            {
                db.vadKhoas.Add(vadKhoa);
                db.SaveChanges();
                return RedirectToAction("VadIndex");
            }

            return View(vadKhoa);
        }

        // GET: VadKhoas/Edit/5
        public ActionResult VadEdit(string id)
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

        // POST: VadKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VadEdit([Bind(Include = "VadMaKH,VadTenKH,VadTrangThai")] vadKhoa vadKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vadKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("VadIndex");
            }
            return View(vadKhoa);
        }

        // GET: VadKhoas/Delete/5
        public ActionResult VadDelete(string id)
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

        // POST: VadKhoas/Delete/5
        [HttpPost, ActionName("VadDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult VadDeleteConfirmed(string id)
        {
            vadKhoa vadKhoa = db.vadKhoas.Find(id);
            db.vadKhoas.Remove(vadKhoa);
            db.SaveChanges();
            return RedirectToAction("VadIndex");
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
