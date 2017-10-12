using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Controllers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.UnitTests.Autos4Sale.ControllersTests.OffersControllerTests
{
    [TestFixture]
    public class Constructor_Should
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