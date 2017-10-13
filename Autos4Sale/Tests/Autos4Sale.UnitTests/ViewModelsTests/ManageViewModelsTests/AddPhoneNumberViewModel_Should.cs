using Autos4Sale.Web.ViewModels.Manage;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.ManageViewModelsTests
{
    [TestFixture]
   public class AddPhoneNumberViewModel_Should
    {
        [TestCase]
        public void NumberProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new AddPhoneNumberViewModel();
            var testNumber = "35912133213";

            // Act
            viewModel.Number = testNumber;

            // Assert
            Assert.AreEqual(testNumber, viewModel.Number);
        }
    }
}
