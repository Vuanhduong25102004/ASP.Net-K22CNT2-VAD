
using Lab05_1.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab05_1.Controllers
{
    public class VADMemberController : Controller
    {
        // GET: VADMember
        // GET: /Member/CreateOne

        public ActionResult CreateOne()

        {

            return View();

        }

        //POST: /Member/CreateOne

        [HttpPost]

        public ActionResult CreateOne(Member m)

        {

            //chuyển dữ liệu nhận được tới View Details

            return View("Details", m);

        }

        //GET: /Member/CreateTwo

        public ActionResult CreateTwo()

        {

            return View();

        }

        //POST: /Member/CreateTwo

        [HttpPost]

        public ActionResult CreateTwo(VADMember m)

        {

            //kiểm tra trống các trường và thông báo lỗi tới VIEW

            if (m.Id == null)

            {

                ViewBag.error = "Hãy nhập mã số";

                return View();

            }

            if (m.Username == null)

            {

                ViewBag.error = "Hãy nhập tên đăng nhập";

                return View();

            }

            if (m.FullName == null)

            {

                ViewBag.error = "Hãy nhập tên họ và tên";

                return View();

            }

            if (m.Age == null)

            {

                ViewBag.error = "Hãy nhập tuổi";

                return View();

            }

            if (m.Email == null)

            {

                ViewBag.error = "Hãy nhập Email";

                return View();

            }

            //mẫu kiểm tra Email

            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";

            if (!System.Text.RegularExpressions.Regex.IsMatch(m.Email, regexPattern))

            {

                ViewBag.error = "Hãy nhập đúng định dạng";

                return View();

            }

            //nếu không xảy ra lỗi thì chuyển dữ liệu tới View Details

            return View("Details", m);

        }

        //GET: /Member/CreateThree

        public ActionResult CreateThree()

        {

            return View();

        }

        //POST: /Member/CreateThree

        [HttpPost]

        public ActionResult CreateThree(Member m)

        {

            //nếu trạng thái dữ liệu của Model hợp lệ thì chuyển dữ liệu tới View Details

            if (ModelState.IsValid)

                return View("Details", m);

            else

                return View(); //quay lại view Three để báo lỗi

        }

        //GET: /Member/Details

        public ActionResult Details()

        {

            return View();

        }
    }
}