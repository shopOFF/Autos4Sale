using Autos4Sale.Web.ViewModels.Account;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.AccountViewModelsTests
{
    [TestFixture]
    public class VerifyCodeViewModel_Should
    {
        [TestCase]
        public void ProviderProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new VerifyCodeViewModel();
            var testProvider = "provider";

            // Act
            viewModel.Provider = testProvider;

            // Assert
            Assert.AreEqual(testProvider, viewModel.Provider);
        }

        [TestCase]
        public void CodeProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new VerifyCodeViewModel();
            var testCode = "code";

            // Act
            viewModel.Code= testCode;

            // Assert
            Assert.AreEqual(testCode, viewModel.Code);
        }

        [TestCase]
        public void ReturnUrlProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new VerifyCodeViewModel();
            var testReturnUrl = "abv.bg";

            // Act
            viewModel.ReturnUrl = testReturnUrl;

            // Assert
            Assert.AreEqual(testReturnUrl, viewModel.ReturnUrl);
        }

        [TestCase]
        public void RememberBrowserProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new VerifyCodeViewModel();
            var testRememberBrowser = true;

            // Act
            viewModel.RememberBrowser = testRememberBrowser;

            // Assert
            Assert.AreEqual(testRememberBrowser, viewModel.RememberBrowser);
        }

        [TestCase]
        public void RememberMeProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new VerifyCodeViewModel();
            var testRememberMe = true;

            // Act
            viewModel.RememberMe= testRememberMe;

            // Assert
            Assert.AreEqual(testRememberMe, viewModel.RememberMe);
        }
    }
}
