using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autos4Sale.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarOffersService carOffersService;

        public HomeController(ICarOffersService carOffersService)
        {
            this.carOffersService = carOffersService;
        }

        public ActionResult Index()
        {
            var carOffers = this.carOffersService
                .GetAll()
                .Select(x => new CarOfferViewModel()
                {
                    AuthorEmail = x.Author.Email,
                    Brand = x.Brand,
                    Model = x.Model,
                    YearManufacured = x.YearManufacured
                })
                .ToList();

            return View(carOffers);
        }

        [Authorize(Roles = "Admin, User")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}