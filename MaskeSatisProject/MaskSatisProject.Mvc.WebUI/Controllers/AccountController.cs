using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.Business.Dependency_Resolvers.Validation.FluentValidation;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;
using System.Web.Security;

namespace MaskSatisProject.Mvc.WebUI.Controllers
{
    public class AccountController : Controller
    {
        
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string tcno,string sifre,Users user)
        {
            LoginCheckValidate userValidation = new LoginCheckValidate();
            ValidationResult result = userValidation.Validate(user);
            if (result.IsValid == false)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View();
            }
            else
            {
                var users = _userService.LoginCheckUser(tcno, sifre);
                if (users == null)
                {
                    ModelState.AddModelError("LogError", "Giriş başarısız bilgilerinizi kontrol ediniz.");

                    return View(users);

                }
                else
                {
                    string userdetails = users.FirstName + " " + users.LastName;
                    FormsAuthentication.SetAuthCookie(userdetails,false);
                    Session["KullanıcıUID"] = users.TcNo;
                    Session.Timeout = 50;
                    return RedirectToAction("Index", "HomePage");
                }
            }
           
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Account");
        }
    }
}