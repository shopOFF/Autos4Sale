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
    }
}
