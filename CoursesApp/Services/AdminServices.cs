using CoursesApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesApp.Services
{
    public interface IAdminService
    {
         bool LogIn(string Email , string Password);
         bool ChangePassword(string Email , string Password);
         bool ForgetPassword(string Email);



    }
    public class AdminServices : IAdminService
    {
        public CoursesDBEntities context { get; set; }
        public AdminServices()
        {
            context = new CoursesDBEntities();
        }
        public bool ChangePassword(string Email, string Password)
        {
            return false;
        }

        public bool ForgetPassword(string Email)
        {
            throw new NotImplementedException();
        }

        public bool LogIn(string Email, string Password)
        {
            return context.admins.Where(a => a.admin_email == Email && a.admin_password == Password).Any();
        }
    }
}