using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Autos4Sale.Services.Contracts;
using Moq;
using NUnit.Framework;
using System;

namespace Autos4Sale.UnitTests.ServicesTests.UserServiceTests
{
    [TestFixture]
    public class ReturnCurrentUser_Should
    {
        [TestCase]
        public void ReturnCurrentUser_WhenValidParametersArePased_ShouldCallSaveImagesMethod()
        {
            // Arrange
            var user = new User();
            var userServiceMock = new Mock<IUserService>();
            userServiceMock.Setup(x => x.ReturnCurrentUser(null,null)).Returns(user);

            // Act
            userServiceMock.Object.ReturnCurrentUser();

            // Assert
            userServiceMock.Verify(x => x.ReturnCurrentUser(null,null), Times.Once);
        }

        [TestCase]
        public void ReturnCurrentUserId_WhenValidParameterCurrUserIdIsPased_ShouldSetCorrectly()
        {
            // Arrange
            var userId = "testId";
            var usersRepoMock = new Mock<IEfRepository<User>>();
            var userService = new UserService(usersRepoMock.Object);

            // Act
            var result = userService.ReturnCurrentUser(userId);

            // Assert
            Assert.AreEqual(userId, userService.CurrentUserId);
        }

        [TestCase]
        public void ReturnCurrentUserId_WhenValidParametersAre_ShouldReturnCorrectResult()
        {
            // Arrange
            var user = new User();
            var userId = "testId";
            var usersRepoMock = new Mock<IEfRepository<User>>();
            var userService = new UserService(usersRepoMock.Object);

            // Act
            var result = userService.ReturnCurrentUser(userId, user);

            // Assert
            Assert.AreEqual(userId, userService.CurrentUserId);
        }

        [TestCase]
        public void ReturnCurrentUserId_WhenInValidValidParameterCurrUserIdIsPased_ShouldThrowNullReferenceException()
        {
            // Arrange
            var user = new User();
            var usersRepoMock = new Mock<IEfRepository<User>>();
            var userService = new UserService(usersRepoMock.Object);

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => userService.ReturnCurrentUser(null, user));
        }

        [TestCase]
        public void ReturnCurrentUser_WhenValidParametercurrUserIsPased_ShouldSetCorrectly()
        {
            // Arrange
            var user = new User();
            var usersRepoMock = new Mock<IEfRepository<User>>();
            var userService = new UserService(usersRepoMock.Object);

            // Act
            var result = userService.ReturnCurrentUser("id",user);

            // Assert
            Assert.AreEqual(user, userService.CurrentUser);
        }

        [TestCase]
        public void ReturnCurrentUser_WhenInValidParametercurrUserIsPased_ShouldReturnNull()
        {
            // Arrange
            var user = new User();
            var usersRepoMock = new Mock<IEfRepository<User>>();
            var userService = new UserService(usersRepoMock.Object);

            // Act & Assert
            Assert.IsNull(userService.ReturnCurrentUser("id", null));
        }

        [TestCase]
        public void ReturnCurrentUser_WhenBothInValidParametersArePased_ShouldThrowNullReferenceException()
        {
            // Arrange
            var usersRepoMock = new Mock<IEfRepository<User>>();
            var userService = new UserService(usersRepoMock.Object);

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => userService.ReturnCurrentUser(null, null));

        }
    }
}
