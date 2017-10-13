using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services;
using Moq;
using NUnit.Framework;
using System;

namespace Autos4Sale.UnitTests.ServicesTests.ImageServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenInValidParametersArePased_ShouldThrowArgumentNullException()
        {
            //  Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ImageService(null));
        }
    }
}
