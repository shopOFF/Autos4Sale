using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Autos4Sale.Services.Contracts;
using Moq;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ServicesTests.CarOffersServiceTests
{
    [TestFixture]
    public class Delete_Should
    {
        [TestCase]
        public void Delete_WhenValidParametersArePased_ShouldCallDeleteMethod()
        {
            // Arrange
            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();
            var carOffer = new CarOffer();
            var carOffer2 = new CarOffer();

            var serviceMock = new Mock<ICarOffersService>();
            serviceMock.Setup(x => x.Delete(carOffer));

            // Act
            serviceMock.Object.Delete(carOffer);

            // Assert
            serviceMock.Verify(x => x.Delete(carOffer), Times.Once);
        }
        [TestCase]
        public void Delete_WhenValidParametersArePased_ShouldCallEfRepositoryMethodDelete()
        {
            // Arrange
            var carOffer = new CarOffer();

            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            efRepoMock.Setup(x => x.Delete(carOffer));
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();

            var serviceMock = new CarOffersService(efRepoMock.Object, efUnitOfWorkMock.Object);

            // Act
            serviceMock.Delete(carOffer);

            // Assert
            efRepoMock.Verify(x => x.Delete(carOffer), Times.Once);
        }

        [TestCase]
        public void Delete_WhenValidParametersArePased_ShouldCallUnitOfWorkMethodCommit()
        {
            // Arrange
            var carOffer = new CarOffer();

            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();
            efUnitOfWorkMock.Setup(x => x.Commit());

            var service = new CarOffersService(efRepoMock.Object, efUnitOfWorkMock.Object);

            // Act
            service.Delete(carOffer);
            service.Delete(carOffer);

            // Assert
            efUnitOfWorkMock.Verify(x => x.Commit(), Times.Exactly(2));
        }
    }
}
