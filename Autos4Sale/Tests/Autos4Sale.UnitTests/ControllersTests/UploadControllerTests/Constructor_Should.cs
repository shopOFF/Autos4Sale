using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Controllers;
using Moq;
using NUnit.Framework;
using System;

namespace Autos4Sale.UnitTests.ControllersTests.UploadControllerTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void UploadConstructor_WhenValidParametersArePased_ShouldNotBeNull()
        {
            // Arrange
            var carOffersServiceMock = new Mock<ICarOffersService>();
            var userServiceMock = new Mock<IUserService>();
            var imageServiceMock = new Mock<IImageService>();
            //
            // Act
            UploadController offersController = new UploadController(carOffersServiceMock.Object, imageServiceMock.Object, userServiceMock.Object);

            // Assert
            Assert.IsNotNull(offersController);
        }

        [TestCase]
        public void UploadConstructor_WhenInValidParametersArePased_ShouldThrowArgumentNullException()
        {
            // Arrange
            var result = new UploadController(null, null, null);
            // Act & Assert
            Assert.That(() => result.ValueProvider, Throws.ArgumentNullException);

        }
    }
}
