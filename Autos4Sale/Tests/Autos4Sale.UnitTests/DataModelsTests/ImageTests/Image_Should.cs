using Autos4Sale.Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autos4Sale.UnitTests.DataModelsTests.ImageTests
{
    [TestFixture]
    public class Image_Should
    {
        [TestCase]
        public void IsDeletedProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var image = new Image();

            // Act
            image.IsDeleted = true;

            // Assert
            Assert.AreEqual(true, image.IsDeleted);
        }

        [TestCase]
        public void ImageUrlProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var image = new Image();
            var imageUrl = "imageUrl";

            // Act
            image.ImageUrl = imageUrl;

            // Assert
            Assert.AreEqual(imageUrl, image.ImageUrl);
        }

        [TestCase]
        public void AuthorProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var image = new Image();
            var author = new User();

            // Act
            image.Author = author;

            // Assert
            Assert.AreEqual(author, image.Author);
        }

        [TestCase]
        public void CarOfferProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var image = new Image();
            var offer = new CarOffer();

            // Act
            image.CarOffer = offer;

            // Assert
            Assert.AreEqual(offer, image.CarOffer);
        }

        [TestCase]
        public void CreatedOnProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var image = new Image();
            var date = DateTime.Now;

            // Act
            image.CreatedOn = date;

            // Assert
            Assert.AreEqual(date, image.CreatedOn);
        }

        [TestCase]
        public void ModifiedOnProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var image = new Image();
            var date = DateTime.Now;

            // Act
            image.ModifiedOn = date;

            // Assert
            Assert.AreEqual(date, image.ModifiedOn);
        }

        [TestCase]
        public void DeletedOnProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var image = new Image();
            var date = DateTime.Now;

            // Act
            image.DeletedOn = date;

            // Assert
            Assert.AreEqual(date, image.DeletedOn);
        }
    }
}
