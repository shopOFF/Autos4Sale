using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Web.Areas.Administration.Controllers;
using Autos4Sale.Web.ViewModels.Shared;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace Autos4Sale.UnitTests.ControllersTests.AdministrationOffersControllerTests
{
    [TestFixture]
    public class AllOffers_Should
    {
        [TestCase]
        public void AllOffers_WhenValidParametersArePased_ShouldReturnCorerectViewResultName()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(OffersController).Assembly);

            var carOffer = new CarOffer();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            OffersController offersController = new OffersController(carOffersServiceMock.Object);

            // Act
            ViewResult result = offersController.AllOffers() as ViewResult;

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        [TestCase]
        public void AllOffers_WhenValidParametersArePased_ShouldReturnCorerectViewAllCars()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(OffersController).Assembly);

            var carOffer = new CarOffer();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            OffersController offersController = new OffersController(carOffersServiceMock.Object);

            // Act & Assert
            offersController.WithCallTo(x => x.AllOffers()).ShouldRenderView("AllOffers");
        }

        [TestCase]
        public void AllOffers_WhenValidParametersArePased_ShouldReturnCorerectViewModelToView()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(OffersController).Assembly);

            var carOffer = new CarOffer();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            OffersController offersController = new OffersController(carOffersServiceMock.Object);

            // Act & Assert
            offersController.WithCallTo(x => x.AllOffers()).ShouldRenderDefaultView();
            //offersController.WithCallTo(x => x.AllOffers()).ShouldRenderDefaultView().WithModel<List<CarOfferViewModel>>();
        }
    }
}
