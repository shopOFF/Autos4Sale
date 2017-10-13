using Autos4Sale.Services;
using NUnit.Framework;
using System;

namespace Autos4Sale.UnitTests.ServicesTests.UserServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [TestCase]
        public void Constructor_WhenInValidParametersArePased_ShouldThrowArgumentNullException()
        {
            //  Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new UserService(null));
        }
    }
}
