using Autos4Sale.Web.ViewModels;
using Autos4Sale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Infrastructure;
using Autos4Sale.Data.Models.Enums;

namespace Autos4Sale.Web.Controllers
{
    public class UploadController : Controller
    {
        private readonly ICarOffersService carOffersService;
        private readonly IImageService imageService;

        public UploadController(ICarOffersService carOffersService, IImageService imageService)
        {
            this.carOffersService = carOffersService;
            this.imageService = imageService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin, User")]
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin, User")]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(CarOfferViewModel offer, IEnumerable<HttpPostedFileBase> images)
        {
            var imgs = this.imageService.SaveImages(images);

            var carOffer = new CarOffer()
            {
                Author = imgs.FirstOrDefault().Author,
                Brand = offer.Brand,
                Model = offer.Model,
                Description = offer.Description,
                CreatedOn = DateTime.Now,
                Image = imgs,
                Color = ColorType.Aqua,
                Engine = EngineType.Diesel,
                Transmission = TransmissionType.Automatic,
                CarCategory = CarCategoryType.Cabriolet,
                Mileage = 200000,
                HorsePower = 200,
                Location = "unknown",
                Price = 2222,
                SellersCurrentPhone = "123242342122",
                YearManufacured = 2009
            };

            this.carOffersService.Add(carOffer);

            return RedirectToAction("Index", "Home");
        }
    }
}