using Autos4Sale.Web.ViewModels.Manage;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.ManageViewModelsTests
{
    [TestFixture]
    public class SetPasswordViewModel_Should
    {
        [TestCase]
        public void NewPasswordProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new SetPasswordViewModel();
            var testNewPassword = "359112312";

            // Act
            viewModel.NewPassword = testNewPassword;

            // Assert
            Assert.AreEqual(testNewPassword, viewModel.NewPassword);
        }

        [TestCase]
        public void ConfirmPasswordProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new SetPasswordViewModel();
            var testConfirmPassword = "359112312";

            // Act
            viewModel.ConfirmPassword = testConfirmPassword;

            // Assert
            Assert.AreEqual(testConfirmPassword, viewModel.ConfirmPassword);
        }
    }
}
