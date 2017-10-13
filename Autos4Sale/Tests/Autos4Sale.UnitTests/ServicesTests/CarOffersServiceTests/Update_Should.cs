using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Autos4Sale.Services.Contracts;
using Moq;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ServicesTests.CarOffersServiceTests
{
    [TestFixture]
    public class Update_Should
    {
        [TestCase]
        public void Update_WhenValidParametersArePased_ShouldCallUpdateMethod()
        {
            // Arrange
            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();
            var carOffer = new CarOffer();
            var carOffer2 = new CarOffer();

            var serviceMock = new Mock<ICarOffersService>();
            serviceMock.Setup(x => x.Update(carOffer));

            // Act
            serviceMock.Object.Update(carOffer);

            // Assert
            serviceMock.Verify(x => x.Update(carOffer), Times.Once);
        }
        [TestCase]
        public void Update_WhenValidParametersArePased_ShouldCallEfRepositoryMethodUpdate()
        {
            // Arrange
            var carOffer = new CarOffer();

            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            efRepoMock.Setup(x => x.Update(carOffer));
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();

            var serviceMock = new CarOffersService(efRepoMock.Object, efUnitOfWorkMock.Object);

            // Act
            serviceMock.Update(carOffer);

            // Assert
            efRepoMock.Verify(x => x.Update(carOffer), Times.Once);
        }

        [TestCase]
        public void Update_WhenValidParametersArePased_ShouldCallUnitOfWorkMethodCommit()
        {
            // Arrange
            var carOffer = new CarOffer();

            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();
            efUnitOfWorkMock.Setup(x => x.Commit());

            var service = new CarOffersService(efRepoMock.Object, efUnitOfWorkMock.Object);

            // Act
            service.Update(carOffer);
            service.Update(carOffer);

            // Assert
            efUnitOfWorkMock.Verify(x => x.Commit(), Times.Exactly(2));
        }
    }
}
