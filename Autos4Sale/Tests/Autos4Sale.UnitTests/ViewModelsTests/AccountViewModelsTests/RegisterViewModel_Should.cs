using Autos4Sale.Web.ViewModels.Account;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.AccountViewModelsTests
{
    [TestFixture]
    public class RegisterViewModel_Should
    {
        [TestCase]
        public void EmailProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new RegisterViewModel();
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
            var viewModel = new RegisterViewModel();
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
            var viewModel = new RegisterViewModel();
            var testPass = "123456";

            // Act
            viewModel.ConfirmPassword = testPass;

            // Assert
            Assert.AreEqual(testPass, viewModel.ConfirmPassword);
        }
    }
}
