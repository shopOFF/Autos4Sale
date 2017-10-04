using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.Services
{
    public class CarOffersService
    {
        private readonly IEfRepository<CarOffer> carOffersRepo;

        public CarOffersService(IEfRepository<CarOffer> carOffersRepo)
        {
            this.carOffersRepo = carOffersRepo;
        }

        public IQueryable<CarOffer> GetAll()
        {
            return this.carOffersRepo.GetAll;
        }
    }
}
