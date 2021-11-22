using FormApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            FormApplication.Models.FormContext context = new FormApplication.Models.FormContext();
            var userObj = context.Users.Where(x => x.Password == model.Password && x.UserName == model.UserName).FirstOrDefault();
            if (userObj != null)
            {
                Session["UserId"] = userObj.UserId;
                Session["Username"] = model.UserName;
                Session["Role"] = userObj.Role;
                return RedirectToAction("Index", "Forms");
            }
            
            return View();
        }
    }
}