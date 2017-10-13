using Autos4Sale.Web.ViewModels.Manage;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.ManageViewModelsTests
{
    [TestFixture]
    public class ChangePasswordViewModel_Should
    {
        [TestCase]
        public void OldPasswordProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ChangePasswordViewModel();
            var testOldPassword = "35912133213";

            // Act
            viewModel.OldPassword = testOldPassword;

            // Assert
            Assert.AreEqual(testOldPassword, viewModel.OldPassword);
        }

        [TestCase]
        public void NewPasswordProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ChangePasswordViewModel();
            var testNewPassword = "35912133213";

            // Act
            viewModel.NewPassword = testNewPassword;

            // Assert
            Assert.AreEqual(testNewPassword, viewModel.NewPassword);
        }

        [TestCase]
        public void ConfirmPasswordProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ChangePasswordViewModel();
            var testConfirmPassword = "35912133213";

            // Act
            viewModel.ConfirmPassword = testConfirmPassword;

            // Assert
            Assert.AreEqual(testConfirmPassword, viewModel.ConfirmPassword);
        }
    }
}
