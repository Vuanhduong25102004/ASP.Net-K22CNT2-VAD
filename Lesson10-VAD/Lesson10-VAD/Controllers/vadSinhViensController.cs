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
    public class vadSinhViensController : Controller
    {
        private VadK22CNT2Lesson10DbEntities3 db = new VadK22CNT2Lesson10DbEntities3();

        // GET: vadSinhViens
        public ActionResult VADSinhvien()
        {
            var vadSinhViens = db.vadSinhViens.Include(v => v.vadKhoa);
            return View(vadSinhViens.ToList());
        }

        // GET: vadSinhViens/Details/5
        public ActionResult VADDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadSinhVien vadSinhVien = db.vadSinhViens.Find(id);
            if (vadSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(vadSinhVien);
        }

        // GET: vadSinhViens/Create
        public ActionResult VADCreate()
        {
            ViewBag.vadMaKH = new SelectList(db.vadKhoas, "vadMaKH", "vadTenKH");
            return View();
        }

        // POST: vadSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VADCreate([Bind(Include = "vadMaSV,vadHoSV,vadTenSV,vadPhai,vadNgaySinh,vadNoiSinh,vadMaKH,vadHocBong,vadDiemTrungBinh")] vadSinhVien vadSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.vadSinhViens.Add(vadSinhVien);
                db.SaveChanges();
                return RedirectToAction("VADSinhvien");
            }

            ViewBag.vadMaKH = new SelectList(db.vadKhoas, "vadMaKH", "vadTenKH", vadSinhVien.vadMaKH);
            return View(vadSinhVien);
        }

        // GET: vadSinhViens/Edit/5
        public ActionResult VADEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadSinhVien vadSinhVien = db.vadSinhViens.Find(id);
            if (vadSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.vadMaKH = new SelectList(db.vadKhoas, "vadMaKH", "vadTenKH", vadSinhVien.vadMaKH);
            return View(vadSinhVien);
        }

        // POST: vadSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VADEdit([Bind(Include = "vadMaSV,vadHoSV,vadTenSV,vadPhai,vadNgaySinh,vadNoiSinh,vadMaKH,vadHocBong,vadDiemTrungBinh")] vadSinhVien vadSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vadSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("VADSinhvien");
            }
            ViewBag.vadMaKH = new SelectList(db.vadKhoas, "vadMaKH", "vadTenKH", vadSinhVien.vadMaKH);
            return View(vadSinhVien);
        }

        // GET: vadSinhViens/Delete/5
        public ActionResult VADDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vadSinhVien vadSinhVien = db.vadSinhViens.Find(id);
            if (vadSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(vadSinhVien);
        }

        // POST: vadSinhViens/Delete/5
        [HttpPost, ActionName("VADDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            vadSinhVien vadSinhVien = db.vadSinhViens.Find(id);
            db.vadSinhViens.Remove(vadSinhVien);
            db.SaveChanges();
            return RedirectToAction("VADSinhvien");
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
