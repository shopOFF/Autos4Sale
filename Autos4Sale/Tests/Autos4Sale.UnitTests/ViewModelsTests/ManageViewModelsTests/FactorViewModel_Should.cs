using Autos4Sale.Web.ViewModels.Manage;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ViewModelsTests.ManageViewModelsTests
{
    [TestFixture]
    public class FactorViewModel_Should
    {
        [TestCase]
        public void PurposeProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var viewModel = new FactorViewModel();
            var testPurpose = "provider";

            // Act
            viewModel.Purpose = testPurpose;

            // Assert
            Assert.AreEqual(testPurpose, viewModel.Purpose);
        }
    }
}
