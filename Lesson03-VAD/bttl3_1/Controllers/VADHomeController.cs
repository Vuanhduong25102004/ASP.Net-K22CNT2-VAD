using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bttl3_1.Controllers
{
    public class VADHomeController : Controller
    {
        public ActionResult Index()
        {
            // Action mặc định
            ViewBag.index = "Bài tập tự làm 3.1" ;
            return View();
        }

        public ActionResult PrimeNumbers()
        {
            // Tìm và in ra các số nguyên tố từ 1-100
            List<int> primeNumbers = new List<int>();
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    primeNumbers.Add(i);
            }
            ViewBag.PrimeNumbers = primeNumbers;
            return View();
        }

        public ActionResult Factorials()
        {
            // Tính và in ra giai thừa từ 1-10
            Dictionary<int, long> factorials = new Dictionary<int, long>();
            long factorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                factorial *= i;
                factorials.Add(i, factorial);
            }
            ViewBag.Factorials = factorials;
            return View();
        }

        public ActionResult MultiplicationTable()
        {
            // Tạo và in ra bảng cửu chương từ 2-9
            Dictionary<int, List<int>> multiplicationTable = new Dictionary<int, List<int>>();
            for (int i = 2; i <= 9; i++)
            {
                List<int> tableRow = new List<int>();
                for (int j = 1; j <= 10; j++)
                {
                    tableRow.Add(i * j);
                }
                multiplicationTable.Add(i, tableRow);
            }
            ViewBag.MultiplicationTable = multiplicationTable;
            return View();
        }
    }
}