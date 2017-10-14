using Autos4Sale.Data.Models;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Web.Controllers;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Moq;
using NUnit.Framework;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace Autos4Sale.UnitTests.ControllersTests.ManageControllerTests
{
    [TestFixture]
    public class SetPassword_Should
    {
        [TestCase]
        public void SetPassword_WhenValidParametersArePased_ShouldReturnCorerectViewResultName()
        {
            // Arrange
            var storeMock = new Mock<IUserStore<User>>();
            var userManager = new ApplicationUserManager(storeMock.Object);

            var authManagerMock = new Mock<IAuthenticationManager>();
            var signInManager = new ApplicationSignInManager(userManager, authManagerMock.Object);

            ManageController manageController = new ManageController(userManager, signInManager);

            // Act
            ViewResult result = manageController.SetPassword() as ViewResult;

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        [TestCase]
        public void SetPassword_WhenValidParametersArePased_ShouldReturnCorerectViewSetPassword()
        {
            // Arrange
            var storeMock = new Mock<IUserStore<User>>();
            var userManager = new ApplicationUserManager(storeMock.Object);

            var authManagerMock = new Mock<IAuthenticationManager>();
            var signInManager = new ApplicationSignInManager(userManager, authManagerMock.Object);

            ManageController manageController = new ManageController(userManager, signInManager);

            // Act & Assert
            manageController.WithCallTo(x => x.SetPassword()).ShouldRenderView("SetPassword");
        }
    }
}
