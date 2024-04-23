using bttl3_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;

namespace bttl3_2.Controllers
{
    public class VADHomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.msg = "Chọn đăng ký để đăng ký thành viên";
            return View();
        }
        public ActionResult FormDKTV()
        {
            ViewBag.listType = new List<LHDN>() {
            new LHDN() { ID = "0", Name = "-- chọn loại hình doanh nghiệp --"},
            new LHDN() { ID = "Hợp danh", Name = "Hợp danh" },
            new LHDN() { ID = "Công ty trách nhiệm hữu hạn", Name = "Công ty trách nhiệm hữu hạn" },
            new LHDN() { ID = "Công ty cổ phần", Name = "Công ty cổ phần" },
            new LHDN() { ID = "Doanh nghiệp xã hội", Name = "Doanh nghiệp xã hội" },
            new LHDN() { ID = "Công ty nhà nước", Name = "Công ty nhà nước" } ,
            new LHDN() { ID = "Doanh nghiệp tư nhân ", Name = "Doanh nghiệp tư nhân " },
            };
            return View();
        }
        public ActionResult DKTV() 
        {
            string fvr = "";
            TempData["tendonvituyen"] = Request["txttendonvituyen"];
            TempData["LHDN"] = Request["LHDN"];
            TempData["soluongthanhvien"] = Request["txtsoluongthanhvien"];
            TempData["diachi"] = Request["txtdiachi"];
            TempData["nguoilienhe"] = Request["txtnguoilienhe"];
            TempData["sodienthoai"] = Request["txtsodienthoai"];
            TempData["sofax"] = Request["txtsofax"];
            TempData["email"] = Request["txtemail"];
            TempData["diachiwebsite"] = Request["txtdiachiwebsite"];
            TempData["username"] = Request["txtusername"];
            TempData["password"] = Request["txtpassword"];
            TempData["Receive"] = Request["btnReceive"];

            return View();
        }
    }
}