using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Web.Controllers;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace Autos4Sale.UnitTests.ControllersTests.HomeControllerTests
{
    [TestFixture]
    public class About_Should
    {
        [TestCase]
        public void About_WhenValidParametersArePased_ShouldReturnCorerectViewResultName()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(HomeController).Assembly);

            var carOffer = new CarOffer();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            HomeController homeController = new HomeController(carOffersServiceMock.Object);

            // Act
            ViewResult result = homeController.About() as ViewResult;

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        [TestCase]
        public void About_WhenValidParametersArePased_ShouldReturnCorerectViewAbout()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(HomeController).Assembly);

            var carOffer = new CarOffer();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            var userServiceMock = new Mock<IUserService>();
            HomeController homeController = new HomeController(carOffersServiceMock.Object);

            // Act & Assert
            homeController.WithCallTo(x => x.About()).ShouldRenderView("About");
        }
    }
}
