using Autos4Sale.Web.ViewModels.Account;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.AccountViewModelsTests
{
    [TestFixture]
    public class ResetPasswordViewModel_Should
    {
        [TestCase]
        public void EmailProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ResetPasswordViewModel();
            var testEmail = "test@abv.bg";

            // Act
            viewModel.Email = testEmail;

            // Assert
            Assert.AreEqual(testEmail, viewModel.Email);
        }

        [TestCase]
        public void PassProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ResetPasswordViewModel();
            var testPass = "123456";

            // Act
            viewModel.Password = testPass;

            // Assert
            Assert.AreEqual(testPass, viewModel.Password);
        }

        [TestCase]
        public void ConfirmPassProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ResetPasswordViewModel();
            var testPass = "123456";

            // Act
            viewModel.ConfirmPassword = testPass;

            // Assert
            Assert.AreEqual(testPass, viewModel.ConfirmPassword);
        }

        [TestCase]
        public void CodeProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ResetPasswordViewModel();
            var testCode = "123456";

            // Act
            viewModel.Code = testCode;

            // Assert
            Assert.AreEqual(testCode, viewModel.Code);
        }
    }
}
