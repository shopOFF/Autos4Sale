using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Autos4Sale.Services.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autos4Sale.UnitTests.ServicesTests.UserServiceTests
{
    [TestFixture]
    public class GetAllUsers_Should
    {
        [TestCase]
        public void GetAllUsers_WhenValidParametersArePased_ShouldReturnAllUsers()
        {
            // Arrange
            var user1 = new User();
            var user2 = new User();
            var user3 = new User();

            var usersRepoMock = new Mock<IEfRepository<User>>();
            usersRepoMock.Setup(x => x.GetAll)
                .Returns(new List<User> { user1, user2, user3 }.AsQueryable());

            var userService = new UserService(usersRepoMock.Object);
            // Act
            var result = userService.GetAllUsers();

            // Assert
            Assert.AreEqual(3, result.Count());
        }
    }
}
