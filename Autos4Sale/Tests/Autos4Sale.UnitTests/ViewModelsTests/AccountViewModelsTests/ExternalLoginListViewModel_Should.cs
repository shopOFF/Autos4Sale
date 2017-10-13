using Autos4Sale.Web.ViewModels.Account;
using NUnit.Framework;


namespace Autos4Sale.UnitTests.ViewModelsTests.AccountViewModelsTests
{
    [TestFixture]
    public class ExternalLoginListViewModel_Should
    {
        [TestCase]
        public void ReturnUrlProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ExternalLoginListViewModel();
            var testUrl = "github.com";

            // Act
            viewModel.ReturnUrl = testUrl;

            // Assert
            Assert.AreEqual(testUrl, viewModel.ReturnUrl);
        }
    }
}
