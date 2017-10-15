using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Moq;
using NUnit.Framework;
using System;

namespace Autos4Sale.UnitTests.ServicesTests.ImageServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenInValidParametersArePased_ShouldThrowArgumentNullException()
        {
            //  Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ImageService(null));
        }

        [TestCase]
        public void Constructor_WhenValidParametersArePased_ShouldNotBeNull()
        {
            //  Arrange
            var efRepoMock = new Mock<IEfRepository<User>>();

            // Act
            var imgService = new ImageService(efRepoMock.Object);

            // Assert
            Assert.IsNotNull(imgService);
        }

        [TestCase]
        public void Constructor_WhenValidParametersArePased_ShouldInitializeCorrectly()
        {
            //  Arrange
            var efRepoMock = new Mock<IEfRepository<User>>();

            // Act
            var imgService = new ImageService(efRepoMock.Object);

            //  Assert
            Assert.IsInstanceOf<ImageService>(imgService);
        }

        [TestCase]
        public void CurrentUserIdProp_WhenValidParametersArePased_ShouldSetCorrectly()
        {
            //  Arrange
            var efRepoMock = new Mock<IEfRepository<User>>();
            var imgService = new ImageService(efRepoMock.Object);
            var currentUserId = "testId-1";

            // Act
            imgService.CurrentUserId = currentUserId;

            //  Assert
            Assert.AreEqual(currentUserId,imgService.CurrentUserId);
        }

        [TestCase]
        public void CurrentUserProp_WhenValidParametersArePased_ShouldSetCorrectly()
        {
            //  Arrange
            var efRepoMock = new Mock<IEfRepository<User>>();
            var imgService = new ImageService(efRepoMock.Object);
            var currentUser = new User();

            // Act
            imgService.CurrentUser = currentUser;

            //  Assert
            Assert.AreEqual(currentUser, imgService.CurrentUser);
        }

        [TestCase]
        public void CurrentUserIdProp_WhenInValidParametersArePased_ShouldThrowNullReferenceException()
        {
            //  Arrange
            var efRepoMock = new Mock<IEfRepository<User>>();
            var imgService = new ImageService(efRepoMock.Object);

            // Act &  Assert
            Assert.Throws<NullReferenceException>(() => imgService.CurrentUserId = null);
        }

        [TestCase]
        public void CurrentUserProp_WhenInValidParametersArePased_ShouldReturnNull()
        {
            //  Arrange
            var efRepoMock = new Mock<IEfRepository<User>>();
            var imgService = new ImageService(efRepoMock.Object);

            // Act & Assert
            Assert.IsNull(imgService.CurrentUser = null);
        }
    }
}
