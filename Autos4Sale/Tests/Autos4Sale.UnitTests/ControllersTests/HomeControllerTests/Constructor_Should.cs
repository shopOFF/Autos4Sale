using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Controllers;
using Moq;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ControllersTests.HomeControllerTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenValidParametersArePasedToId_ShouldNotBeNull()
        {
            // Arrange
            var carOffersServiceMock = new Mock<ICarOffersService>();
          
            // Act
            HomeController offersController = new HomeController(carOffersServiceMock.Object);

            // Assert
            Assert.IsNotNull(offersController);
        }
    }
}
