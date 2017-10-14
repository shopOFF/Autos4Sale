using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Web.Controllers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Moq;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ControllersTests.ManageControllerTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenValidParametersArePasedToId_ShouldNotBeNull()
        {
            // Arrange
            var storeMock = new Mock<IUserStore<User>>();
            var userManager = new ApplicationUserManager(storeMock.Object);

            var authManagerMock = new Mock<IAuthenticationManager>();
            var signInManager = new ApplicationSignInManager(userManager, authManagerMock.Object);

            // Act
            ManageController manageController = new ManageController(userManager, signInManager);

            // Assert
            Assert.IsNotNull(manageController);
        }

        [TestCase]
        public void Constructor_WhenValidParametersArePasedToId_ShouldPassValuesToPropUserManager()
        {
            // Arrange
            var storeMock = new Mock<IUserStore<User>>();
            var userManager = new ApplicationUserManager(storeMock.Object);

            var authManagerMock = new Mock<IAuthenticationManager>();
            var signInManager = new ApplicationSignInManager(userManager, authManagerMock.Object);

            // Act
            ManageController manageController = new ManageController(userManager, signInManager);

            // Assert
            Assert.AreEqual(userManager, manageController.UserManager);
        }

        [TestCase]
        public void Constructor_WhenValidParametersArePasedToId_ShouldPassValuesToPropSignInManager()
        {
            // Arrange
            var storeMock = new Mock<IUserStore<User>>();
            var userManager = new ApplicationUserManager(storeMock.Object);

            var authManagerMock = new Mock<IAuthenticationManager>();
            var signInManager = new ApplicationSignInManager(userManager, authManagerMock.Object);

            // Act
            ManageController manageController = new ManageController(userManager, signInManager);

            // Assert
            Assert.AreEqual(signInManager, manageController.SignInManager);
        }
    }
}
