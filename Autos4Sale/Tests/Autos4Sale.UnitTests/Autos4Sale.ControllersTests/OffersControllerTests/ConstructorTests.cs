using System;
using Moq;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Controllers;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.Autos4Sale.ControllersTests.OffersControllerTests
{
    [TestFixture]
    public class ConstructorTests
    {

        [TestCase]
        public void OffersConstructor_WhenValidParametersArePased_ShouldNotBeNull()
        {
            // Arrange
            var carOffersServiceMock = new Mock<ICarOffersService>();
            var userServiceMock = new Mock<IUserService>();
            //
            // Act
            OffersController offersController = new OffersController(carOffersServiceMock.Object, userServiceMock.Object);

            // Assert
            Assert.IsNotNull(offersController);
        }
    }
}
