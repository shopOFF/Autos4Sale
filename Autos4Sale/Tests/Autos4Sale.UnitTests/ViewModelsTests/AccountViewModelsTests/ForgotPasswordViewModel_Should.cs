using Autos4Sale.Web.ViewModels.Account;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.AccountViewModelsTests
{
    [TestFixture]
    public class ForgotPasswordViewModel_Should
    {
        [TestCase]
        public void EmailProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ForgotPasswordViewModel();
            var testEmail = "test@abv.bg";

            // Act
            viewModel.Email = testEmail;

            // Assert
            Assert.AreEqual(testEmail, viewModel.Email);
        }
    }
}
