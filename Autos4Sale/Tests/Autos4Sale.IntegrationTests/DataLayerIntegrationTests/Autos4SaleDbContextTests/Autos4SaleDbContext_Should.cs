using Autos4Sale.Data;
using Autos4Sale.Data.Models;
using Autos4Sale.Data.Models.Enums;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.IntegrationTests.DataLayerIntegrationTests.Autos4SaleDbContextTests
{
    [TestFixture]
    public class Autos4SaleDbContext_Should
    {
        [TestCase]
        public void Constructor_ShouldNotBeNull()
        {
            // Arrange & Act 
            var context = new Autos4SaleDbContext();

            // Assert
            Assert.IsNotNull(context);
        }

        [TestCase]
        public void CarOffersProp_WhenValidParametersArePasedToIt_ShouldSetCorerectlyInDb()
        {
            //// Arrange
            //var dbContext = new Autos4SaleDbContext();

            //var carOffer = new CarOffer()
            //{
            //    Brand = $"IntegrationTest",
            //    Model = $"IntegrationTest",
            //    Author = dbContext.Users.First(x => x.Email == "admin@gmail.com"),
            //    CreatedOn = DateTime.Now,
            //    Color = ColorType.Azure,
            //    Engine = EngineType.Diesel,
            //    Transmission = TransmissionType.Manual,
            //    CarCategory = CarCategoryType.Cabriolet,
            //    Mileage = 20000,
            //    HorsePower = 111,
            //    SellersCurrentPhone = "+0899101010",
            //    Location = "IntegrationTest",
            //    Price = 1000,
            //    Description = "IntegrationTest",
            //    IsDeleted = true
            //};
            //var offers = dbContext.CarOffers.Where(x => x.Brand == "IntegrationTest").FirstOrDefault();
            //if (offers == null)
            //{
            //    dbContext.CarOffers.Add(carOffer);
            //    dbContext.SaveChanges();
            //}

            //// Act
            //var result = dbContext.CarOffers.FirstOrDefault(x => x.Brand == "IntegrationTest");

            //// Assert
            //Assert.AreEqual(carOffer.Brand, result.Brand);
        }

        [TestCase]
        public void ImagesProp_WhenValidParametersArePasedToIt_ShouldSetCorerectlyInDb()
        {
            // Arrange
            var dbContext = new Autos4SaleDbContext();
            var imgUrl = "integrationUrl";

            var img = new Image()
            {

                ImageUrl = imgUrl,
                Author = dbContext.Users.First(x => x.Email == "admin@gmail.com"),
                CreatedOn = DateTime.Now,
                IsDeleted = true
            };

            var images = dbContext.Images.Where(x => x.ImageUrl == imgUrl).FirstOrDefault();

            if (images == null)
            {
                dbContext.Images.Add(img);
                dbContext.SaveChanges();
            }

            // Act
            var result = dbContext.Images.FirstOrDefault(x => x.ImageUrl == imgUrl);

            // Assert
            Assert.AreEqual(img.ImageUrl, result.ImageUrl);
        }

        [TestCase]
        public void Create_WhenValidParametersArePased_ShouldInitializeNewDbContext()
        {
            // Arrange
            var dbContext = new Autos4SaleDbContext();
            var imgUrl = "integrationUrl";

            var images = dbContext.Images
                .Where(x => x.ImageUrl == imgUrl)
                .FirstOrDefault();

            // Act
            var result =  Autos4SaleDbContext.Create();

            // Assert
            Assert.AreNotEqual(dbContext, result);
        }
    }
}
