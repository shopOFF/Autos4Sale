using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Areas.Administration.ViewModels;
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
        private readonly IUserService userService;

        public OffersController(ICarOffersService carOffersService, IUserService userService)
        {
            this.carOffersService = carOffersService;
            this.userService = userService;
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

        [HttpGet]
        [Authorize(Roles = "Admin, User")]
        public ActionResult YourOffers()
        {
            var currentUser = this.userService.ReturnCurrentUser();

            var yourCarOffers = this.carOffersService
            .GetAll()
            .Where(x => x.Author.Id == currentUser.Id)
            .MapTo<CarOfferViewModel>()
            .ToList();

            return View(yourCarOffers);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, User")]
        public ActionResult EditOffer(Guid? id)
        {
            var carOffer = this.carOffersService
           .GetAll()
           .Where(x => x.Id == id)
           .MapTo<EditableCarOfferViewModel>()
           .FirstOrDefault();

            return View(carOffer);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, User")]
        [ValidateAntiForgeryToken]
        public ActionResult EditOffer(EditableCarOfferViewModel offer)
        {
            var carOffer = new CarOffer()
            {
                Id = offer.Id,
                Author = offer.Author,
                Brand = offer.Brand,
                Model = offer.Model,
                Description = offer.Description,
                Image = offer.Image,
                Color = offer.Color,
                Engine = offer.Engine,
                CreatedOn = DateTime.Now,
                Transmission = offer.Transmission,
                CarCategory = offer.CarCategory,
                Mileage = offer.Mileage,
                HorsePower = offer.HorsePower,
                Location = offer.Location,
                Price = offer.Price,
                SellersCurrentPhone = offer.SellersCurrentPhone,
                YearManufacured = offer.YearManufacured
            };

            this.carOffersService.Update(carOffer);

            return RedirectToAction("AllCars", "Offers");
        }
    }
}