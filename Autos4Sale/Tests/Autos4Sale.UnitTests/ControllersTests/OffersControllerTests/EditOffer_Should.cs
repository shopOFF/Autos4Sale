using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Web.Areas.Administration.ViewModels;
using Autos4Sale.Web.Controllers;
using Autos4Sale.Web.ViewModels.Shared;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace Autos4Sale.UnitTests.ControllersTests.OffersControllerTests
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
            OffersController offersController = new OffersController(carOffersServiceMock.Object, userServiceMock.Object);

            // Act
            ViewResult result = offersController.EditOffer(guid) as ViewResult;

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
        }
    }
}
