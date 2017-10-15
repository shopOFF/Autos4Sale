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
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenValidParametersArePased_ShouldNotBeNull()
        {
            // Arrange
            var user = new User();
            var usersRepoMock = new Mock<IEfRepository<User>>();

            // Act
            var userService = new UserService(usersRepoMock.Object);

            // Assert
            Assert.IsNotNull(userService);
        }

        [TestCase]
        public void Constructor_WhenValidParametersArePased_ShouldInitializeCorrectly()
        {
            // Arrange
            var user = new User();
            var usersRepoMock = new Mock<IEfRepository<User>>();

            // Act
            var userService = new UserService(usersRepoMock.Object);

            // Assert
            Assert.IsInstanceOf<IUserService>(userService);
        }

        [TestCase]
        public void Constructor_WhenInValidParametersArePased_ShouldThrowArgumentNullException()
        {
            //  Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new UserService(null));
        }
    }
}
