using Autos4Sale.Web.ViewModels.Manage;
using NUnit.Framework;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Autos4Sale.UnitTests.ViewModelsTests.ManageViewModelsTests
{
    [TestFixture]
    public class ConfigureTwoFactorViewModel_Should
    {
        [TestCase]
        public void SelectedProviderProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ConfigureTwoFactorViewModel();
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
            var viewModel = new ConfigureTwoFactorViewModel();
            var testsProviders = new List<SelectListItem>();

            // Act
            viewModel.Providers = testsProviders;

            // Assert
            Assert.AreEqual(testsProviders, viewModel.Providers);
        }
    }
}
