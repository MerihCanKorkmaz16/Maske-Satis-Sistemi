using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.Business.Dependency_Resolvers.Validation.FluentValidation;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;
using MaskSatisProject.Mvc.WebUI.Filters;

namespace MaskSatisProject.Mvc.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        private IUserService _userService;
        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult SaveUser()
        {
            return View();
        }
        [HttpPost]
        [ExceptionHandlerAttritube]
        public ActionResult SaveUser(Users user,string tcno)
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
                var checkeduser = _userService.GetUser(tcno);
                if (checkeduser == null)
                {
                    _userService.UserAdd(user);
                    TempData["Success"] = "Başarıyla kaydınız oluşturuldu.";
                    return View(user);
                }
                ModelState.AddModelError("RegisterError", "Tc ye kayıtlı kullanıcı bulunuyor");
                return View();
            }
            
        }
    }
}