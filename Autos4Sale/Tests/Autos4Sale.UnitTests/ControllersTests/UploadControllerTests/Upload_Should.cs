using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.App_Start;
using Autos4Sale.Web.Controllers;
using Autos4Sale.Web.ViewModels.Shared;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace Autos4Sale.UnitTests.ControllersTests.UploadControllerTests
{
    [TestFixture]
    public class Upload_Should
    {
        [TestCase]
        public void Upload_WhenValidParametersArePased_ShouldReturnCorerectViewResultName()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(UploadController).Assembly);

            var carOffer = new CarOffer();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            var imageServiceMock = new Mock<IImageService>();
            var userServiceMock = new Mock<IUserService>();
            UploadController uploadController = new UploadController(carOffersServiceMock.Object, imageServiceMock.Object, userServiceMock.Object);

            // Act
            ViewResult result = uploadController.Upload() as ViewResult;

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        [TestCase]
        public void Upload_WhenInValidParameterImagesIsProvided_ShouldReturnArgumentNullException()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(UploadController).Assembly);

            var carOffer = new CarOffer();
            var carOfferViewModel = new CarOfferViewModel();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            var imageServiceMock = new Mock<IImageService>();
            var userServiceMock = new Mock<IUserService>();
            UploadController uploadController = new UploadController(carOffersServiceMock.Object, imageServiceMock.Object, userServiceMock.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => uploadController.Upload(carOfferViewModel, null));
        }

        [TestCase]
        public void Upload_WhenValidParameterAreProvided_ShouldReturnTheDefaoultContreller()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(UploadController).Assembly);

            var carOffer = new CarOffer();
            var carOfferViewModel = new CarOfferViewModel();
            var fileToPass = new List<HttpPostedFileBase>();

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            var imageServiceMock = new Mock<IImageService>();
            var userServiceMock = new Mock<IUserService>();
            UploadController uploadController = new UploadController(carOffersServiceMock.Object, imageServiceMock.Object, userServiceMock.Object);

            // Act & Assert
            uploadController.WithCallTo(x => x.Upload(carOfferViewModel, fileToPass)).ShouldRedirectToRoute(string.Empty);
        }

        [TestCase]
        public void Upload_WhenImageNullIsPassed_ShouldReturnUploadView()
        {
            // Arrange
            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(typeof(UploadController).Assembly);

            var carOffer = new CarOffer();
            var carOfferViewModel = new CarOfferViewModel();
            var fileToPass = new List<HttpPostedFileBase>();
            fileToPass.Add(null);

            var carOffersServiceMock = new Mock<ICarOffersService>();
            carOffersServiceMock.Setup(x => x.GetAll())
                .Returns(() => new List<CarOffer> { carOffer }.AsQueryable());

            var imageServiceMock = new Mock<IImageService>();
            var userServiceMock = new Mock<IUserService>();
            UploadController uploadController = new UploadController(carOffersServiceMock.Object, imageServiceMock.Object, userServiceMock.Object);

            // Act & Assert
            uploadController.WithCallTo(x => x.Upload(carOfferViewModel, fileToPass)).ShouldRenderView("Upload");
        }
    }
}
