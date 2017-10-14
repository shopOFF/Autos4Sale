using Autos4Sale.Data;
using Autos4Sale.Data.Common;
using Autos4Sale.Data.Common.Repositories;
using Autos4Sale.Data.Models;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.DataCommontTests.EfRepositoryTests
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
            var efRepo = new EfRepository<CarOffer>(dbContext);

            // Assert
            Assert.IsNotNull(efRepo);
        }
    }
}
