using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Autos4Sale.Services.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Web;


namespace Autos4Sale.UnitTests.ServicesTests.ImageServiceTests
{
    [TestFixture]
    public class RenameImage_Should
    {
        [TestCase]
        public void RenameImage_WhenValidNullabeParameterCurrentUserIdIsPased_ShouldSetPropCorrectly()
        {
            // Arrange

            var user = new User();
            var efRepoMock = new Mock<IEfRepository<User>>();
            var imageService = new ImageService(efRepoMock.Object);
            var currentUserId = "id-1";

            // Act
            var result = imageService.RenameImage(1, currentUserId, user);

            // Assert
            Assert.AreEqual(currentUserId, imageService.CurrentUserId);
        }

        [TestCase]
        public void RenameImage_WhenValidNullabeParameterCurrentUserIsPased_ShouldSetPropCorrectly()
        {
            // Arrange

            var user = new User();
            var efRepoMock = new Mock<IEfRepository<User>>();
            var imageService = new ImageService(efRepoMock.Object);
            var currentUserId = "id-1";

            // Act
            var result = imageService.RenameImage(1, currentUserId, user);

            // Assert
            Assert.AreEqual(user, imageService.CurrentUser);
        }

        [TestCase]
        public void RenameImage_WhenValidParametersArePased_ShouldReturnCorrectRenamedImage()
        {
            // Arrange

            var user = new User();
            user.Email = "test@abv.bg";
            var efRepoMock = new Mock<IEfRepository<User>>();
            var imageService = new ImageService(efRepoMock.Object);
            var currentUserId = "id-1";
            var counter = 1;

            var expectedResult = $"{user.Email}-image-{counter}";

            // Act
            var result = imageService.RenameImage(counter, currentUserId, user);

            // Assert
            StringAssert.Contains(expectedResult, result);
        }
    }
}
