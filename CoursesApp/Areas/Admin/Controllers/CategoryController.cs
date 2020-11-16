using CoursesApp.Data;
using CoursesApp.Models;
using CoursesApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoursesApp.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryServices categoryServices { get; set; }
        public CategoryController() { categoryServices = new CategoryServices(); }
        // GET: Admin/Category
        public ActionResult Index()
        {
            List<category> category = categoryServices.GetAllCategory();
            List<CategoryModel> CategoryList = new List<CategoryModel>();
            foreach (category ct in category)
            {
                CategoryList.Add(new CategoryModel { Name = ct.ctg_name, Id = ct.ctg_id, ParentId = ct.ctg_parent_id });
            }
            return View(CategoryList);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CategoryModel newCategory)
        {
            if (ModelState.IsValid)
            {
              var creationResult =   categoryServices.Create(new category() { ctg_name = newCategory.Name});

                if (creationResult == -1)
                {
                    ViewBag.message = "This Category Is Already Exist";
                    return View(newCategory);
                }
                return RedirectToAction("index");
            }
            return View();

        }

    }
}