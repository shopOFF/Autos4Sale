using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Moq;
using NUnit.Framework;
using System;

namespace Autos4Sale.UnitTests.ServicesTests.CarOffersServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenValidParametersArePased_ShouldSetUpCorrectly()
        {
            // Arrange
            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();

            // Act
            var service = new CarOffersService(efRepoMock.Object, efUnitOfWorkMock.Object);

            // Assert
            Assert.IsNotNull(service);
        }

        [TestCase]
        public void Constructor_WhenInValidParameterEfRepositoryIsPased_ShouldThrowNullReferenceException()
        {
            // Arrange
            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new CarOffersService(null, efUnitOfWorkMock.Object));
        }

        [TestCase]
        public void Constructor_WhenInValidParameterIEfUnitOfWorkIsPased_ShouldThrowNullReferenceException()
        {
            // Arrange
            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new CarOffersService(efRepoMock.Object, null));
        }
    }
}
