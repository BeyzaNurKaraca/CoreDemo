using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EntityFrameworkCategoryRepository()); //oluşturduğumuz cm nesnesi sayesinde bütün metotlara erişebileceğiz
        public IActionResult List()
        {
            var values = cm.GetList();
            return View(values);
        }
        //[HttpGet]
        //public IActionResult Create()
        //{
           
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create()
        //{
            
        //    return RedirectToAction();
        //}



    }
}
