using System;
using Moq;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Areas.Administration.Controllers;
using NUnit.Framework;

namespace Autos4Sale.UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            // Arrange
            var carOffersServiceMock = new Mock<ICarOffersService>();
            var userServiceMock = new Mock<IUserService>();
            //
            // Act
            OffersController offersController = new OffersController(userServiceMock.Object, carOffersServiceMock.Object);

            // Assert
            Assert.IsNotNull(offersController);
        }
    }
}
