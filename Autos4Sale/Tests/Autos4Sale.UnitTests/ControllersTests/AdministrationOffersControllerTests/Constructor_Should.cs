using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Areas.Administration.Controllers;
using Moq;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ControllersTests.AdministrationOffersControllerTests
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
            OffersController offersController = new OffersController(userServiceMock.Object, carOffersServiceMock.Object);

            // Assert
            Assert.IsNotNull(offersController);
        }
    }
}
