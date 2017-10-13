using Autos4Sale.Web.ViewModels.Manage;
using Microsoft.AspNet.Identity;
using NUnit.Framework;
using System.Collections.Generic;

namespace Autos4Sale.UnitTests.ViewModelsTests.ManageViewModelsTests
{
    [TestFixture]
    public class IndexViewModel_Should
    {
        [TestCase]
        public void HasPasswordProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new IndexViewModel();
            var testHasPassword = true;

            // Act
            viewModel.HasPassword = testHasPassword;

            // Assert
            Assert.AreEqual(testHasPassword, viewModel.HasPassword);
        }

        [TestCase]
        public void LoginsProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new IndexViewModel();
            var testLogins = new List<UserLoginInfo>();

            // Act
            viewModel.Logins = testLogins;

            // Assert
            Assert.AreEqual(testLogins, viewModel.Logins);
        }

        [TestCase]
        public void PhoneNumberProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new IndexViewModel();
            var testPhoneNumber = "359112312";

            // Act
            viewModel.PhoneNumber = testPhoneNumber;

            // Assert
            Assert.AreEqual(testPhoneNumber, viewModel.PhoneNumber);
        }

        [TestCase]
        public void TwoFactorProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new IndexViewModel();
            var testTwoFactor = true;

            // Act
            viewModel.TwoFactor = testTwoFactor;

            // Assert
            Assert.AreEqual(testTwoFactor, viewModel.TwoFactor);
        }

        [TestCase]
        public void BrowserRememberedProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new IndexViewModel();
            var testBrowserRemembered = true;

            // Act
            viewModel.BrowserRemembered = testBrowserRemembered;

            // Assert
            Assert.AreEqual(testBrowserRemembered, viewModel.BrowserRemembered);
        }
    }
}
