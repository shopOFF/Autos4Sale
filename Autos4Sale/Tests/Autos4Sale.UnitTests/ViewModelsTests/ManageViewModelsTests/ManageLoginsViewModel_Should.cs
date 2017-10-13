using Autos4Sale.Web.ViewModels.Manage;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using NUnit.Framework;
using System.Collections.Generic;

namespace Autos4Sale.UnitTests.ViewModelsTests.ManageViewModelsTests
{
    [TestFixture]
    public class ManageLoginsViewModel_Should
    {
        [TestCase]
        public void CurrentLoginsProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ManageLoginsViewModel();
            var testCurrentLogins = new List<UserLoginInfo>();

            // Act
            viewModel.CurrentLogins = testCurrentLogins;

            // Assert
            Assert.AreEqual(testCurrentLogins, viewModel.CurrentLogins);
        }

        [TestCase]
        public void OtherLoginsProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new ManageLoginsViewModel();
            var testOtherLogins = new List<AuthenticationDescription>();

            // Act
            viewModel.OtherLogins = testOtherLogins;

            // Assert
            Assert.AreEqual(testOtherLogins, viewModel.OtherLogins);
        }
    }
}
