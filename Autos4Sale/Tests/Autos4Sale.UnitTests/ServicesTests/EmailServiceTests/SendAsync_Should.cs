using Autos4Sale.Services.Web;
using Microsoft.AspNet.Identity;
using NUnit.Framework;

namespace Autos4Sale.UnitTests.ServicesTests.EmailServiceTests
{
    [TestFixture]
    public class SendAsync_Should
    {
        [TestCase]
        public void SendAsync_WhenInValidParametersArePased_ShouldReturnNull()
        {
            // Arrange
            var emailService = new EmailService();
            var msg = new IdentityMessage();

            // Act
            var result = emailService.SendAsync(msg);

            // Assert
            Assert.AreEqual(null, result.AsyncState);
        }
    }
}
