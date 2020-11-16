using CoursesApp.Areas.Admin.Models;
using CoursesApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoursesApp.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account/Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel loginmodel)
        {
            AdminServices adminservices = new AdminServices();

            bool modelState = adminservices.LogIn(loginmodel.Email, loginmodel.Password);

            if (modelState)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                loginmodel.message = "Invalid Password or Email";
                return View(loginmodel);
            }
           
        }
    }
}