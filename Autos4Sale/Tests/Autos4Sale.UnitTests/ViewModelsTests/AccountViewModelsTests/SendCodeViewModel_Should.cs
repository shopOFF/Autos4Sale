using Autos4Sale.Web.ViewModels.Account;
using NUnit.Framework;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Autos4Sale.UnitTests.ViewModelsTests.AccountViewModelsTests
{
    [TestFixture]
    public class SendCodeViewModel_Should
    {
        [TestCase]
        public void SelectedProviderProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new SendCodeViewModel();
            var testSelectedProvider = "provider";

            // Act
            viewModel.SelectedProvider = testSelectedProvider;

            // Assert
            Assert.AreEqual(testSelectedProvider, viewModel.SelectedProvider);
        }

        [TestCase]
        public void ProvidersProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new SendCodeViewModel();
            var testsProviders = new List<SelectListItem>();

            // Act
            viewModel.Providers = testsProviders;

            // Assert
            Assert.AreEqual(testsProviders, viewModel.Providers);
        }

        [TestCase]
        public void ReturnUrlProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new SendCodeViewModel();
            var testReturnUrl= "abv.bg";

            // Act
            viewModel.ReturnUrl = testReturnUrl;

            // Assert
            Assert.AreEqual(testReturnUrl, viewModel.ReturnUrl);
        }

        [TestCase]
        public void RememberMeProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new SendCodeViewModel();

            // Act
            viewModel.RememberMe = true;

            // Assert
            Assert.AreEqual(true, viewModel.RememberMe);
        }
    }
}
