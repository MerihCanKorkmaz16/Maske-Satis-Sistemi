using FluentValidation.Results;
using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.Business.Dependency_Resolvers.Validation.FluentValidation;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaskSatisProject.Mvc.WebUI.Controllers
{
    public class ProfileController : Controller
    {
        private IUserService _userService;
        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }
        [Authorize]
        [HttpGet]
        public ActionResult UserProfile()
        {
            string userUID = Session["KullanıcıUID"].ToString();
            var getuserdetails = _userService.GetUser(userUID);
            return View(getuserdetails);
        }

        [HttpPost]
        [Authorize]
        public ActionResult UserProfile(Users user)
        {
            UserValidation userValidation = new UserValidation();
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
                _userService.UpdateUser(user);
                TempData["Success"] = "Bilgiler başarıyla güncellendi";
                return View(user);
            }
           
        }
    }
}