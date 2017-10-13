﻿using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Web.Areas.Administration.Controllers;
using Autos4Sale.Web.Areas.Administration.ViewModels;
using Autos4Sale.Web.ViewModels.Shared;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace Autos4Sale.UnitTests.ControllersTests.AdministrationOffersControllerTests
{
    [TestFixture]
    public class DeleteOffer_Should
    {
        [TestCase]
        public void DeleteOffer_WhenValidParametersArePased_ShouldCallDeleteMethod()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(OffersController).Assembly);

            var carOffer = new CarOffer();
            var guid = Guid.NewGuid();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            carOffersServiceMock.Setup(x => x.Delete(carOffer));

            var userServiceMock = new Mock<IUserService>();
            OffersController offersController = new OffersController(userServiceMock.Object, carOffersServiceMock.Object);

            // Act
            carOffersServiceMock.Object.Delete(carOffer);

            // Assert
            carOffersServiceMock.Verify(x => x.Delete(carOffer), Times.Once);
        }

        [TestCase]
        public void DeleteOffer_WhenInValidParametersArePased_ShouldReturnNull()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(OffersController).Assembly);

            var carOffer = new CarOffer();
            var guid = Guid.NewGuid();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            carOffersServiceMock.Setup(x => x.Delete(carOffer));

            var userServiceMock = new Mock<IUserService>();
            OffersController offersController = new OffersController(userServiceMock.Object, carOffersServiceMock.Object);

            // Act
            ViewResult result = offersController.DeleteOffer(guid) as ViewResult;

            // Assert
            Assert.IsNull(result);
        }
    }
}