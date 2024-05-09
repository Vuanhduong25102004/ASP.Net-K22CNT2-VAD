using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson04_VAD.Controllers
{
    public class VadStudentController : Controller
    {
        /// <summary>
        /// Author: Vũ Anh Dương
        /// </summary>
        /// <returns></returns>
        // GET: VadStudent
        public ActionResult Index()
        {
            ViewBag.fullName = "Vũ Anh Dương";
            ViewData["Birthday"] = "25/10/2004";
            TempData["Phone"] = "0972471680";
            return View();
        }
        
        public ActionResult Details()
        {
            string vadStr = "";
            vadStr += "<h3>Họ và tên: Vũ Anh Dương </h3>";
            vadStr += "<p> Mã sv: 2210900017 </p>";
            vadStr += "<p> Địa chỉ mail: vuanhduong251020042@gmail.com </p>";

            ViewBag.Details = vadStr ;

            return View("chiTiet");
        }

        public ActionResult NgonNguRazor()
        {
            return View();
        }

        // HTMLHelper
        // GET: VadStudent/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            //lấy dữ liệu trên form
            string fullname = form["fullName"];
            string masv = form["maSV"];
            string taikhoan = form["Taikhoan"];
            string matkhau = form["Matkhau"];

            string vadStr = "<h3>" + fullname + "</3>";
            vadStr += "<p>" + masv;
            vadStr += "<p>" + taikhoan;
            vadStr += "<p>" + matkhau;

            ViewBag.info = vadStr;
            return View("Ketqua");
        }
    }
}