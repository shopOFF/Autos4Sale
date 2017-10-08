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

        public UploadController(ICarOffersService carOffersService)
        {
            this.carOffersService = carOffersService;
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
            var counter = 1;
            var collectionOfImages = new List<Image>();
            var appUser = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());

            foreach (var image in images)
            {
                var imageNewName = $"{appUser.Email}-image-{counter}-{Guid.NewGuid()}.jpg";

                var imageModel = new Image()
                {
                    ImageUrl = imageNewName,
                    Author = appUser
                };

                collectionOfImages.Add(imageModel);

                image.SaveAs(Server.MapPath($"~/Images/{imageNewName}"));

                counter++;
            }

            var carOffer = new CarOffer()
            {
                Author = appUser,
                Brand = offer.Brand,
                Model = offer.Model,
                Description = offer.Description,
                CreatedOn = DateTime.Now,
                Image = collectionOfImages,
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