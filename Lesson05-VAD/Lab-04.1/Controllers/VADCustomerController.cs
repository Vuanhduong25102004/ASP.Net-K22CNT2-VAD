using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_04._1.Models;

namespace Lab_04._1.Controllers
{
    public class VADCustomerController : Controller
    {
        // GET: VADCustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomerDetail()
        {
            VADCustomer cus = new VADCustomer()
            {
                CustomerId = "2210900017",
                FullName = "Vũ Anh Dương",
                Address = "Hà Nội",
                Email = "vuanhduong251020042@gmail.com",
                Phone = "0972471680",
                Balance = 15200000
            };
            
            return View(cus);
        }
        public ActionResult CustomerList()
        {
            //tạo một danh sách khách hàng
            List<VADCustomer> listcustomer = new List<VADCustomer>()
            {
                new VADCustomer(){ CustomerId = "2210900017",FullName = "Vũ Anh Dương",
                Address = "Hà Nội",Email = "vuanhduong251020042@gmail.com",
                Phone = "0972471680",Balance = 15200000},
                new VADCustomer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
                Address = "Hà Nội",Email = "cucdt@gmail.com",
                Phone = "0986.767.444",Balance = 2200000},
                new VADCustomer(){ CustomerId = "KH003",
                FullName = "Nguyễn Tuấn Thắng",
                Address = "Nam Định",Email = "thangnt@gmail.com",
                Phone = "0924.656.542",Balance = 1200000},
                new VADCustomer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
                Address = "Hà Nội",Email = "hailn@gmail.com",
                Phone = "0996.555.267",Balance = 6200000 }
            };
                //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}