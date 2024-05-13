using BT_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BT_Demo.Controllers
{
    public class VADCustomerScaffdingController : Controller
    {
        // GET: VADCustomerScaffding
        private static List<VADCustomer> listCustomer = new List<VADCustomer>()
                {
               new VADCustomer()
                {
                    CustomerId = 1,
                    FirstName = "Vũ Anh ",
                    LastName = "Dương",
                    Address = "K22CNTT2",
                    YearOfBirth = 2004
                },
               new VADCustomer()
                {
                   CustomerId = 2,
                   FirstName = "Đàm Vĩnh ",
                   LastName = "Trinh",
                   Address = "CNTT2",
                   YearOfBirth = 2022
               },
               new VADCustomer()
                {
                   CustomerId = 3,
                   FirstName = "Đàm Vĩnh ",
                   LastName = "Trinh 1",
                   Address = "CNTT2",
                   YearOfBirth = 2022
               },
               new VADCustomer()
               {
                   CustomerId = 3,
                   FirstName = "Đàm Vĩnh ",
                   LastName = "Trinh 2",
                   Address = "CNTT2",
                   YearOfBirth = 2022
               },
        };
        // GET: VADCustomerScaffding
        // listcustomer
        public ActionResult Index()
        {
            return View(listCustomer); 
        }
        [HttpGet]
        public ActionResult VADCreate()
        {
            var model = new VADCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult VADCreate(VADCustomer model)
        {
            listCustomer.Add(model);
            return RedirectToAction("Index");
        }

        public ActionResult VADEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}
