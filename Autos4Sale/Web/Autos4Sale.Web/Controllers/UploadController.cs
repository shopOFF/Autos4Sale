﻿using Autos4Sale.Web.ViewModels;
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
using AutoMapper;

namespace Autos4Sale.Web.Controllers
{
    public class UploadController : Controller
    {
        private readonly ICarOffersService carOffersService;
        private readonly IImageService imageService;
        private readonly IUserService userService;

        public UploadController(ICarOffersService carOffersService, IImageService imageService, IUserService userService)
        {
            this.carOffersService = carOffersService;
            this.imageService = imageService;
            this.userService = userService;
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

            //var mappedOffer= Mapper.Map<CarOfferViewModel, CarOffer>(offer);

            var carOffer = new CarOffer()
            {
                Author = userService.ReturnCurrentUser(),
                Brand = offer.Brand,
                Model = offer.Model,
                Description = offer.Description,
                Image = imgs,
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

            this.carOffersService.Add(carOffer);

            return RedirectToAction("Index", "Home");
        }
    }
}