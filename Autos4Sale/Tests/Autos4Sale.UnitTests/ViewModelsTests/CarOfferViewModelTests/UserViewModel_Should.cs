using Autos4Sale.Data.Models;
using Autos4Sale.Web.Areas.Administration.ViewModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autos4Sale.UnitTests.ViewModelsTests.CarOfferViewModelTests
{
    [TestFixture]
    public class UserViewModel_Should
    {
        [TestCase]
        public void IsDeletedProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var user = new UserViewModel();

            // Act
            user.IsDeleted = true;

            // Assert
            Assert.AreEqual(true, user.IsDeleted);
        }

        [TestCase]
        public void DeletedOnProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var user = new UserViewModel();
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
            var user = new UserViewModel();
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
            var user = new UserViewModel();
            var data = DateTime.Now;
            // Act
            user.ModifiedOn = data;

            // Assert
            Assert.AreEqual(data, user.ModifiedOn);
        }
    }
}
