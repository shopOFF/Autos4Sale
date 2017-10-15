using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Areas.Administration.ViewModels;
using Autos4Sale.Web.Infrastructure;
using Autos4Sale.Web.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace Autos4Sale.Web.Areas.Administration.Controllers
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
        [Authorize(Roles = "Admin")]
        public ActionResult AllOffers()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [OutputCache(Duration = 13)]  // cached for 13 seconds
        public ActionResult GetAllOffers()
        {
            var carOffers = this.carOffersService
                 .GetAll()
                 .Where(x => x.Image.Count != 0)
                 .Where(x => x.IsDeleted == false)
                 .MapTo<CarOfferViewModel>()
                 .ToList();

            return PartialView("_GetAllOffersPartial", carOffers);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult EditOffer(EditableCarOfferViewModel offer)
        {
            if (this.ModelState.IsValid)
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

                return RedirectToAction("AllOffers", "Offers");
            }

            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteOffer(Guid? id)
        {
            var carOfferToDelete = this.carOffersService
                .GetAll()
                .Where(x => x.Id == id)
                .FirstOrDefault();

            this.carOffersService.Delete(carOfferToDelete);

            return RedirectToAction("AllOffers", "Offers");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult ManageUsers()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult ManageUsers([DataSourceRequest]DataSourceRequest request)
        {
            var users = this.userService
                .GetAllUsers()
                .MapTo<UserViewModel>()
                .ToDataSourceResult(request);
 
            return this.Json(users);
        }
    }
}