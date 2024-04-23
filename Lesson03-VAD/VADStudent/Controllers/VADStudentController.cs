using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VADStudent.Controllers
{
    public class VADStudentController : Controller
    {
        // GET: VADStudent
        public ActionResult Index()
        {
            ViewData["msg"] = "View Data - Vũ Anh Dương";
            ViewData["time"]= DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }

        public ActionResult StudentList()
        {
            //su dung viewbag
            //luu tru gia tri don
            ViewBag.titleName = "Danh sách học viên - Vũ Anh Dương";

            //gia tri la mot tap hop
            string[] names = {"Vũ Văn A", "Vũ Văn B", "Vũ Văn C", "Vũ Văn D" };
            ViewBag.list = names;

            //gia tri la mot doi tuong
            var obj = new
            {
                ID=100,
                Name="Vũ Anh Dương",
                Age=20
            };
            ViewBag.student = obj;
            return View();
        }

        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}