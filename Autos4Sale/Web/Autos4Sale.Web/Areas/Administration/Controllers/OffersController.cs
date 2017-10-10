using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autos4Sale.Web.Areas.Administration.Controllers
{
    public class OffersController : Controller
    {
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult EditOffer()
        {
            return View();
        }
    }
}