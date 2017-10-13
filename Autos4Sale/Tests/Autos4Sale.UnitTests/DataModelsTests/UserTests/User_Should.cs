using Autos4Sale.Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autos4Sale.UnitTests.DataModelsTests.UserTests
{
    [TestFixture]
    public class User_Should
    {
        [TestCase]
        public void IsDeletedProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var user = new User();

            // Act
            user.IsDeleted = true;

            // Assert
            Assert.AreEqual(true, user.IsDeleted);
        }

        [TestCase]
        public void DeletedOnProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var user = new User();
            var data = DateTime.Now;
            // Act
            user.DeletedOn = data;

            // Assert
            Assert.AreEqual(data, user.DeletedOn);
        }

        [TestCase]
        public void CreatedOnProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var user = new User();
            var data = DateTime.Now;
            // Act
            user.CreatedOn = data;

            // Assert
            Assert.AreEqual(data, user.CreatedOn);
        }

        [TestCase]
        public void ModifiedOnProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var user = new User();
            var data = DateTime.Now;
            // Act
            user.ModifiedOn = data;

            // Assert
            Assert.AreEqual(data, user.ModifiedOn);
        }

        [TestCase]
        public void CarOffersProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var user = new User();
            var offer = new CarOffer();

            // Act
            user.CarOffers = new List<CarOffer>() { offer };

            // Assert
            Assert.AreEqual(offer, user.CarOffers.FirstOrDefault());
        }
    }
}
