using Autos4Sale.Data.Models;
using Autos4Sale.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace Autos4Sale.Web.ViewModels
{
    public class CarOfferViewModel : IMapFrom<CarOffer>, IHaveCustomMappings
    {
        private ICollection<Image> image;

        public CarOfferViewModel()
        {
            this.image = new HashSet<Image>();
        }

        public string AuthorEmail { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int YearManufacured { get; set; }

        public string Description { get; set; }

        public ICollection<Image> Image
        {
            get { return this.image; }
            set { image = value; }
        }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CarOffer, CarOfferViewModel>()
                .ForMember(viewModel => viewModel.AuthorEmail, cfg => cfg.MapFrom(model => model.Author.Email));
        }
    }
}