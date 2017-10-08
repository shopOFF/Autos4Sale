using Autos4Sale.Data.Models;
using Autos4Sale.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Autos4Sale.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Autos4Sale.Web.ViewModels
{
    public class CarOfferViewModel : IMapFrom<CarOffer>, IHaveCustomMappings
    {
        private ICollection<Image> image;

        public CarOfferViewModel()
        {
            this.image = new HashSet<Image>();
        }

        public User Author { get; set; }

        [Display(Name = "Car Manufacurer")]
        public string Brand { get; set; }

        [Display(Name = "Car Model")]
        public string Model { get; set; }

        public int YearManufacured { get; set; }

        public TransmissionType Transmission { get; set; }

        public EngineType Engine { get; set; }

        public CarCategoryType CarCategory { get; set; }

        public int Mileage { get; set; }

        public int HorsePower { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string SellersCurrentPhone { get; set; }

        public ColorType Color { get; set; }

        public string Location { get; set; }

        public ICollection<Image> Image
        {
            get { return this.image; }
            set { image = value; }
        }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //configuration.CreateMap<CarOffer, CarOfferViewModel>()
            //    .ForMember(viewModel => viewModel.AuthorEmail, cfg => cfg.MapFrom(model => model.Author.Email));
        }
    }
}