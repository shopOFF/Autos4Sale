using Autos4Sale.Web.ViewModels.Account;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.AccountViewModelsTests
{
    [TestFixture]
    public class LoginViewModel_Should
    {
        [TestCase]
        public void EmailProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new LoginViewModel();
            var testEmail = "test@abv.bg";

            // Act
            viewModel.Email = testEmail;

            // Assert
            Assert.AreEqual(testEmail, viewModel.Email);
        }

        [TestCase]
        public void PasswordProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new LoginViewModel();
            var testPass = "123456";

            // Act
            viewModel.Password= testPass;

            // Assert
            Assert.AreEqual(testPass, viewModel.Password);
        }

        [TestCase]
        public void RememberMeProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new LoginViewModel();
            var testBool = true;

            // Act
            viewModel.RememberMe = testBool;

            // Assert
            Assert.AreEqual(testBool, viewModel.RememberMe);
        }
    }
}
