using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaskSatisProject.Mvc.WebUI.Controllers
{
    public class BuyMaskController : Controller
    {
        private IMaskService _maskService;
        private IUserService _userService;
        public BuyMaskController(IMaskService maskService,IUserService userService)
        {
            _maskService = maskService;
            _userService = userService;
        }

        [Authorize]
        public ActionResult Confirm()
        {
            string userUID = Session["KullanıcıUID"].ToString();
            var getuserdetails = _userService.GetUser(userUID);
            return View(getuserdetails);
        }
        [HttpPost]
        public ActionResult Confirm(MaskTable maskTable)
        {
            string userUID = Session["KullanıcıUID"].ToString();
            int id = _userService.GetUser(userUID).UserId;
            maskTable.UserId = id;
            maskTable.OperationDate = DateTime.Now;
            _maskService.BuyMask(maskTable);
            return RedirectToAction("Index","HomePage");
        }
    }
}