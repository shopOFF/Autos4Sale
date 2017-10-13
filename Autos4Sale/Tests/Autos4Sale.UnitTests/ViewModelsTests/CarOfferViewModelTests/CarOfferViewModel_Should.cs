using Autos4Sale.Data.Models;
using Autos4Sale.Data.Models.Enums;
using Autos4Sale.Web.ViewModels.Shared;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.UnitTests.ViewModelsTests.CarOfferViewModelTests
{
    [TestFixture]
    public class CarOfferViewModel_Should
    {
        [TestCase]
        public void IdProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testGuidId = Guid.NewGuid();
            // Act
            caroOfferViewModel.Id = testGuidId;

            // Assert
            Assert.AreEqual(testGuidId, caroOfferViewModel.Id);
        }

        [TestCase]
        public void UserProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testUser = new User();
            // Act
            caroOfferViewModel.Author = testUser;

            // Assert
            Assert.AreEqual(testUser, caroOfferViewModel.Author);
        }

        [TestCase]
        public void BrandProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testBrand = "VW";
            // Act
            caroOfferViewModel.Brand = testBrand;

            // Assert
            Assert.AreEqual(testBrand, caroOfferViewModel.Brand);
        }

        [TestCase]
        public void ModelProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testModel= "Passat";

            // Act
            caroOfferViewModel.Model= testModel;

            // Assert
            Assert.AreEqual(testModel, caroOfferViewModel.Model);
        }

        [TestCase]
        public void YearManufacuredProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testYearManufacured = 2001;

            // Act
            caroOfferViewModel.YearManufacured = testYearManufacured;

            // Assert
            Assert.AreEqual(testYearManufacured, caroOfferViewModel.YearManufacured);
        }

        [TestCase]
        public void TransmissionProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testTransmission = TransmissionType.Manual;

            // Act
            caroOfferViewModel.Transmission = testTransmission;

            // Assert
            Assert.AreEqual(testTransmission, caroOfferViewModel.Transmission);
        }

        [TestCase]
        public void EngineProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testEngine = EngineType.Diesel;

            // Act
            caroOfferViewModel.Engine = testEngine;

            // Assert
            Assert.AreEqual(testEngine, caroOfferViewModel.Engine);
        }

        [TestCase]
        public void CarCategoryProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testCarCategory = CarCategoryType.Estate;

            // Act
            caroOfferViewModel.CarCategory = testCarCategory;

            // Assert
            Assert.AreEqual(testCarCategory, caroOfferViewModel.CarCategory);
        }

        [TestCase]
        public void MileageProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testMileage = 240000;

            // Act
            caroOfferViewModel.Mileage = testMileage;

            // Assert
            Assert.AreEqual(testMileage, caroOfferViewModel.Mileage);
        }

        [TestCase]
        public void HorsePowerProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testHorsePower = 101;

            // Act
            caroOfferViewModel.HorsePower = testHorsePower;

            // Assert
            Assert.AreEqual(testHorsePower, caroOfferViewModel.HorsePower);
        }

        [TestCase]
        public void DescriptionProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testDescription = "Perfect";

            // Act
            caroOfferViewModel.Description = testDescription;

            // Assert
            Assert.AreEqual(testDescription, caroOfferViewModel.Description);
        }

        [TestCase]
        public void SellersCurrentPhoneProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testSellersCurrentPhone = "359899104343";

            // Act
            caroOfferViewModel.SellersCurrentPhone = testSellersCurrentPhone;

            // Assert
            Assert.AreEqual(testSellersCurrentPhone, caroOfferViewModel.SellersCurrentPhone);
        }

        [TestCase]
        public void ColorProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testColor = ColorType.Blue;

            // Act
            caroOfferViewModel.Color = testColor;

            // Assert
            Assert.AreEqual(testColor, caroOfferViewModel.Color);
        }

        [TestCase]
        public void LocationProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testLocation = "Sofia";

            // Act
            caroOfferViewModel.Location = testLocation;

            // Assert
            Assert.AreEqual(testLocation, caroOfferViewModel.Location);
        }

        [TestCase]
        public void ModifiedOnProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testModifiedOn = DateTime.Now;

            // Act
            caroOfferViewModel.ModifiedOn = testModifiedOn;

            // Assert
            Assert.AreEqual(testModifiedOn, caroOfferViewModel.ModifiedOn);
        }

        [TestCase]
        public void PriceProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testPrice = 2500;

            // Act
            caroOfferViewModel.Price = testPrice;

            // Assert
            Assert.AreEqual(testPrice, caroOfferViewModel.Price);
        }

        [TestCase]
        public void ImageProp_WhenValidParametersArePasedToId_ShouldSetCorerectly()
        {
            // Arrange
            var caroOfferViewModel = new CarOfferViewModel();
            var testImage = new Image();

            // Act
            caroOfferViewModel.Image = new List<Image>() { testImage };

            // Assert
            Assert.AreEqual(testImage, caroOfferViewModel.Image.FirstOrDefault());
        }
    }
}
