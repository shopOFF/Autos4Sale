using Autos4Sale.Data;
using Autos4Sale.Data.Common;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.DataCommontTests.EfUnitOfWorkTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenValidParametersArePasedToId_ShouldNotBeNull()
        {
            // Arrange
            var dbContext = new Autos4SaleDbContext();

            // Act
            var efUnitOfWork = new EfUnitOfWork(dbContext);

            // Assert
            Assert.IsNotNull(efUnitOfWork);
        }
    }
}
