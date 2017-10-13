using Autos4Sale.Services.Web;
using Microsoft.AspNet.Identity;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ServicesTests.SmsServiceTests
{
    [TestFixture]
    public class SendAsync_Should
    {
        [TestCase]
        public void SendAsync_WhenInValidParametersArePased_ShouldReturnNull()
        {
            // Arrange
            var smsService = new SmsService();
            var msg = new IdentityMessage();

            // Act
            var result = smsService.SendAsync(msg);

            // Assert
            Assert.AreEqual(null, result.AsyncState);
        }
    }
}
