﻿using Autos4Sale.Data.Models;
using Autos4Sale.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace Autos4Sale.Web.Models
{
    public class CarOfferViewModel : IMapFrom<CarOffer>, IHaveCustomMappings
    {
        public string AuthorEmail { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int YearManufacured { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CarOffer, CarOfferViewModel>()
                .ForMember(viewModel => viewModel.AuthorEmail, cfg => cfg.MapFrom(model => model.Author.Email));
        }
    }
}