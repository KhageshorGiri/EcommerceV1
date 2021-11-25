using Ecommerce.Entities;
using Ecommerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesServices service = new CategoriesServices();

        // GET: Category
        public ActionResult Index()
        {
            var categories = service.getCategories();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            service.saveCategory(category);
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var value = service.getCatagory(Id);
            return View(value);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            service.updateCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var category = service.getCatagory(Id);
            return View(category);
        }

        [HttpPost]
        public ActionResult ConformDelete(int Id)
        {
            service.deleteCategory(Id);
            return RedirectToAction("Index");
        }
    }
}