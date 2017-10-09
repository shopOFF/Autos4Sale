using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Infrastructure;
using Autos4Sale.Web.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autos4Sale.Web.Controllers
{
    public class OffersController : Controller
    {
        private readonly ICarOffersService carOffersService;

        public OffersController(ICarOffersService carOffersService)
        {
            this.carOffersService = carOffersService;
        }

        [HttpGet]
        public ActionResult AllCars()
        {
            var carOffers = this.carOffersService
                 .GetAll()
                 .Where(x => x.Image.Count != 0)
                 .MapTo<CarOfferViewModel>()
                 .ToList();

            return View(carOffers);
        }

        [HttpGet]
        public ActionResult Details(Guid? id)
        {
            if (id != null)
            {
                var carOffers = this.carOffersService
                .GetAll()
                .Where(x => x.Id == id)
                .MapTo<CarOfferViewModel>()
                .FirstOrDefault();

                return View(carOffers);
            }

            return RedirectToAction("AllCars");
        }
    }
}