using Autos4Sale.Data;
using Autos4Sale.Data.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.UnitTests.DataLayerTests.Autos4SaleDbContextTests
{
    [TestFixture]
    public class Autos4SaleDbContext_Should
    {
        [TestCase]
        public void Constructor_ShouldNotBeNull()
        {
            // Arrange & Act 
            var context = new Autos4SaleDbContext();

            // Assert
            Assert.IsNotNull(context);
        }
    }
}
