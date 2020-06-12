using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.Entities.ComplexType;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MaskSatisProject.Mvc.WebUI.Controllers
{
    public class HomePageController : Controller
    {
        private IUserService _userService;
        private IMaskService _maskService;
        public HomePageController(IUserService userService,IMaskService maskService)
        {
            _userService = userService;
            _maskService = maskService;
        }
        [Authorize]

        [HttpGet]
        public ActionResult Index(int? page)
        {
            string tcno = Session["KullanıcıUID"].ToString();
            var merih = _userService.GetUser(tcno);
            List<MaskDetails> maskdetails = _maskService.GetMaskDetails(merih.UserId);
            TempData["MaskCount"] = maskdetails.Count().ToString();
            return View(maskdetails.ToList().ToPagedList(page ?? 1,2));
        }

        
    }
}