using Autos4Sale.Data.Models;
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
    public class EditOffer_Should
    {
        [TestCase]
        public void EditOffer_WhenValidParametersArePased_ShouldReturnCorerectViewResultName()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(OffersController).Assembly);

            var carOffer = new CarOffer();
            var guid = Guid.NewGuid();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            var userServiceMock = new Mock<IUserService>();
            OffersController offersController = new OffersController(userServiceMock.Object, carOffersServiceMock.Object);

            // Act
            ViewResult result = offersController.EditOffer(guid) as ViewResult;

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        [TestCase]
        public void EditOffer_WhenValidParametersArePased_ShouldCallUpdateMethod()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(OffersController).Assembly);

            var carOffer = new CarOffer();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.Update(carOffer)).Verifiable();
            carOffersServiceMock.Object.Update(carOffer);

            var userServiceMock = new Mock<IUserService>();
            OffersController offersController = new OffersController(userServiceMock.Object, carOffersServiceMock.Object);
            var editableCarOfferViewModel = new EditableCarOfferViewModel();
            // Act
            ViewResult result = offersController.EditOffer(editableCarOfferViewModel) as ViewResult;

            // Assert
            carOffersServiceMock.Verify(x => x.Update(carOffer), Times.Once);
        }

        [TestCase]
        public void EditOffer_WhenInValidIdIsPased_ShouldRedirectToHomeViewRoute()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(OffersController).Assembly);

            var carOffer = new CarOffer();
            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.Update(carOffer)).Verifiable();
            carOffersServiceMock.Object.Update(carOffer);

            var userServiceMock = new Mock<IUserService>();
            OffersController offersController = new OffersController(userServiceMock.Object, carOffersServiceMock.Object);
            var editableCarOfferViewModel = new EditableCarOfferViewModel();

            // Act & Assert
            offersController.WithCallTo(x => x.EditOffer(editableCarOfferViewModel)).ShouldRedirectToRoute(string.Empty);
        }
    }
}
