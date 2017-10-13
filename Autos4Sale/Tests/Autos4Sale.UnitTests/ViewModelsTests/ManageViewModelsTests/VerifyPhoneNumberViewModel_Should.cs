using Autos4Sale.Web.ViewModels.Manage;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.ManageViewModelsTests
{
    [TestFixture]
   public class VerifyPhoneNumberViewModel_Should
    {
        [TestCase]
        public void CodeProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new VerifyPhoneNumberViewModel();
            var testCode = "359112312";

            // Act
            viewModel.Code = testCode;

            // Assert
            Assert.AreEqual(testCode, viewModel.Code);
        }

        [TestCase]
        public void PhoneNumberProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new VerifyPhoneNumberViewModel();
            var testPhoneNumber = "359112312";

            // Act
            viewModel.PhoneNumber = testPhoneNumber;

            // Assert
            Assert.AreEqual(testPhoneNumber, viewModel.PhoneNumber);
        }
    }
}
