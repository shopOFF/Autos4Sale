using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Controllers;
using Autos4Sale.Web.ViewModels.Account;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.FluentMVCTesting;

namespace Autos4Sale.UnitTests.ControllersTests.AccountControllerTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenProvidersAreNull_ShouldInitiazlieAnyway()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();

            // Act
            var result = new AccountController(null, null);

            //Assert
            Assert.IsInstanceOf<AccountController>(result);
        }

        [TestCase]
        public void LogOff_WhenProvidersAreNotProvided_ShouldThrowNullReferenceException()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();

            // Act
            AccountController controller = new AccountController();

            //Assert
            Assert.Throws<NullReferenceException>(() => controller.LogOff());
        }

        [TestCase]
        public void Login_WhenParaetersAreValid_ShouldRenderView()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();

            // Act
            AccountController controller = new AccountController(null, null);

            //Assert
            controller.WithCallTo(x => x.Login("valid")).ShouldRenderView("");
        }

        [TestCase]
        public void Register_WhenValid_ShouldRenderDefView()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();

            // Act
            AccountController controller = new AccountController(null, null);

            //Assert
            controller.WithCallTo(x => x.Register()).ShouldRenderView("");
        }

        [TestCase]
        public void ConfirmEmail_WhenValid_ShouldRenderViewError()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();

            // Act
            AccountController controller = new AccountController(null, null);

            //Assert
            controller.WithCallTo(x => x.ConfirmEmail(null, null)).ShouldRenderView("Error");
        }


        [TestCase]
        public void ForgotPassword_WhenValid_ShouldRenderDefView()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();

            // Act
            AccountController controller = new AccountController(null, null);

            //Assert
            controller.WithCallTo(x => x.ForgotPassword()).ShouldRenderView("ForgotPassword");
        }

        [TestCase]
        public void ForgotPasswordConfirmation_WhenValid_ShouldRenderDefView()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();

            // Act
            AccountController controller = new AccountController(null, null);

            //Assert
            controller.WithCallTo(x => x.ForgotPasswordConfirmation()).ShouldRenderView("ForgotPasswordConfirmation");
        }

        [TestCase]
        public void ResetPassword_WhenValid_ShouldRenderDefView()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();

            // Act
            AccountController controller = new AccountController(null, null);

            //Assert
            controller.WithCallTo(x => x.ResetPassword("Valid")).ShouldRenderView("ResetPassword");
        }

        [TestCase]
        public void ResetPassword_WhenValid_ShouldRenderErrorView()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();
            AccountController controller = new AccountController(null, null);
            string code = null;

            // Act & Assert
            controller.WithCallTo(x => x.ResetPassword(code)).ShouldRenderView("Error");
        }

        [TestCase]
        public void ResetPasswordConfirmation_WhenValid_ShouldRenderDefView()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();
            AccountController controller = new AccountController(null, null);

            // Act & Assert
            controller.WithCallTo(x => x.ResetPasswordConfirmation()).ShouldRenderView("ResetPasswordConfirmation");
        }

        [TestCase]
        public void ExternalLoginFailure_WhenValid_ShouldRenderDefView()
        {
            // Arrange
            var userServiceMock = new Mock<IUserService>();
            AccountController controller = new AccountController(null, null);
            
            // Act & Assert
            controller.WithCallTo(x => x.ExternalLoginFailure()).ShouldRenderView("ExternalLoginFailure");
        }
    }
}
