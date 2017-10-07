using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autos4Sale.Web.Controllers
{
    public class HideController : Controller
    {
        //[Authorize(Roles = "Admin, User")] // this way works
        public ActionResult Test()
        {
            ViewBag.Message = "Your application description page.";

            if (User.IsInRole("Admin") || User.IsInRole("User"))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
    }
}