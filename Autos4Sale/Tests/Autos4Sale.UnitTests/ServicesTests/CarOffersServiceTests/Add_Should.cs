using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Autos4Sale.Services.Contracts;
using Moq;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ServicesTests.CarOffersServiceTests
{
    [TestFixture]
    public class Add_Should
    {
        [TestCase]
        public void Add_WhenValidParametersArePased_ShouldCallAddMethod()
        {
            // Arrange
            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();
            var carOffer = new CarOffer();
            var carOffer2 = new CarOffer();

            var serviceMock = new Mock<ICarOffersService>();
            serviceMock.Setup(x => x.Add(carOffer));

            // Act
            serviceMock.Object.Add(carOffer);

            // Assert
            serviceMock.Verify(x => x.Add(carOffer), Times.Once);
        }

        [TestCase]
        public void Add_WhenValidParametersArePased_ShouldCallEfRepositoryMethodAdd()
        {
            // Arrange
            var carOffer = new CarOffer();

            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            efRepoMock.Setup(x => x.Add(carOffer));
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();

            var serviceMock = new CarOffersService(efRepoMock.Object, efUnitOfWorkMock.Object);

            // Act
            serviceMock.Add(carOffer);

            // Assert
            efRepoMock.Verify(x => x.Add(carOffer), Times.Once);
        }

        [TestCase]
        public void Add_WhenValidParametersArePased_ShouldCallUnitOfWorkMethodCommit()
        {
            // Arrange
            var carOffer = new CarOffer();

            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();
            efUnitOfWorkMock.Setup(x => x.Commit());

            var service = new CarOffersService(efRepoMock.Object, efUnitOfWorkMock.Object);

            // Act
            service.Add(carOffer);
            service.Add(carOffer);

            // Assert
            efUnitOfWorkMock.Verify(x => x.Commit(), Times.Exactly(2));
        }
    }
}
