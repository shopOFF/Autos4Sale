using Autos4Sale.Web.Areas.Administration;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ControllersTests.AdministrationOffersControllerTests
{
    [TestFixture]
    public class AdminAreaRegistration_Should
    {
        [TestCase]
        public void AreaNameProp_WhenInvoked_ShouldReturnCorerectAreaNameAdministration()
        {
            // Arrange
            var adminReg = new AdministrationAreaRegistration();
            var testAreaName = "Administration";

            // Act & Assert
            Assert.AreEqual(testAreaName, adminReg.AreaName);
        }
    }
}
