using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Autos4Sale.Services.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autos4Sale.UnitTests.ServicesTests.CarOffersServiceTests
{
    [TestFixture]
    public class GetAll_Should
    {
        [TestCase]
        public void GetAll_WhenValidParametersArePased_ShouldReturnAllOffers()
        {
            // Arrange
            var carOffer = new CarOffer();
            var carOffer2 = new CarOffer();

            var efRepoMock = new Mock<IEfRepository<CarOffer>>();
            efRepoMock.Setup(x => x.GetAll)
                .Returns(new List<CarOffer> { carOffer, carOffer2 }.AsQueryable());
            var efUnitOfWorkMock = new Mock<IEfUnitOfWork>();


            var service = new CarOffersService(efRepoMock.Object, efUnitOfWorkMock.Object);
            service.Add(carOffer);
            service.Add(carOffer2);

            // Act
            var result = service.GetAll();

            // Assert
            Assert.AreEqual(2, result.Count());
        }
    }
}
