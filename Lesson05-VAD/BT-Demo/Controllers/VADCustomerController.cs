using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT_Demo.Models;

namespace BT_Demo.Controllers
{
    public class VADCustomerController : Controller
    {
        // GET: VADCustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VADCustomerDetail()
        {
            //Tạo đối tượng dữ liệu 
            var customer = new VADCustomer()
            {
                CustomerId = 1,
                FirstName = "Vũ Anh",
                LastName = "Dương",
                Address = "K22CNTT2",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();

        }
        // GET: VADListCustomer
        public ActionResult VADListCustomer()
        {
            var list = new List<VADCustomer>()
            {
               new VADCustomer()
            {
                CustomerId = 1,
                FirstName="Vũ Anh ",
                LastName="Dương",
                Address="K22CNTT2",
                YearOfBirth=2004
            },
               new VADCustomer()
               {
                   CustomerId=2,
                   FirstName="Đàm Vĩnh ",
                   LastName="Trinh",
                   Address="CNTT2",
                   YearOfBirth=2022
               },
               new VADCustomer()
               {
                   CustomerId=3,
                   FirstName="Đàm Vĩnh ",
                   LastName="Trinh 1",
                   Address="CNTT2",
                   YearOfBirth=2022
               },
               new VADCustomer()
               {
                   CustomerId=3,
                   FirstName="Đàm Vĩnh ",
                   LastName="Trinh 2",
                   Address="CNTT2",
                   YearOfBirth=2022
               },
        };
            //ViewBag.list = list;// Đưa đối tượng ra view bằng viewBag

            return View(list);
        }

    }
}