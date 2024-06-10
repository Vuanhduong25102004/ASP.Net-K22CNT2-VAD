using Lesson08_VAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson08_VAD.Controllers
{
    public class VadCategoryController : Controller
    {
        private static VadBookStore _VadBookStore;
        public VadCategoryController()
        {
            _VadBookStore = new VadBookStore();
        }
        // GET: VadCategory
        public ActionResult VadIndex()
        {
            var vadCategory = _VadBookStore.VadCategories.ToList(); 
            return View(vadCategory);
        }
        [HttpGet]
        public ActionResult VadCreate() 
        {
            var vadCategory = new VadCategory();
            return View();
        }
        [HttpPost]
        public ActionResult VadCreate(VadCategory vadCategory)
        {
            _VadBookStore.VadCategories.Add(vadCategory);
            _VadBookStore.SaveChanges();
            return RedirectToAction("VadIndex");
        }
    }
}