using Autos4Sale.Data;
using Autos4Sale.Data.Common;
using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Microsoft.AspNet.Identity;
using Moq;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.DataCommontTests.EfUnitOfWorkTests
{
    [TestFixture]
    public class Commit_Should
    {
        [TestCase]
        public void Constructor_WhenValidParametersArePasedToId_ShouldNotBeNull()
        {
            // Arrange
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();
            efUnitOfWorkMock.Setup(x => x.Commit());

            // Act
            efUnitOfWorkMock.Object.Commit();
            efUnitOfWorkMock.Object.Commit();

            // Assert
            efUnitOfWorkMock.Verify(x => x.Commit(), Times.Exactly(2));
        }
    }
}
