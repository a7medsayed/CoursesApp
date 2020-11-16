using CoursesApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesApp.Services
{
    interface ICategoryService
        {
        List<category> GetAllCategory();
        int Create(category newCategory);

        }
    public class CategoryServices : ICategoryService
    {
        public CoursesDBEntities context { get; set; }
        public CategoryServices()
        {
            context = new CoursesDBEntities();
        }
        public List<category> GetAllCategory()
        {
            return context.categories.ToList();
        }

        public int Create(category newCategory)
        {
            string CategoryName = newCategory.ctg_name;
            bool ct = context.categories.Where(c => c.ctg_name == CategoryName).Any();
            if (ct)
            {
                return -1;

            }
            context.categories.Add(newCategory);
            return context.SaveChanges();
        }
    }
}