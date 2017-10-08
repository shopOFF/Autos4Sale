using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.Services
{
    public class CarOffersService : ICarOffersService
    {
        private readonly IEfRepository<CarOffer> carOffersRepo;
        private readonly IEfUnitOfWork dbContext;

        public CarOffersService(IEfRepository<CarOffer> carOffersRepo, IEfUnitOfWork dbContext)
        {
            this.carOffersRepo = carOffersRepo;
            this.dbContext = dbContext;
        }

        public IQueryable<CarOffer> GetAll()
        {
            return this.carOffersRepo.GetAll;
        }

        public void Add(CarOffer carOffer)
        {
            this.carOffersRepo.Add(carOffer);

            this.dbContext.Commit();
        }

        public void Update(CarOffer carOffer)
        {
            this.carOffersRepo.Update(carOffer);

            this.dbContext.Commit();
        }
    }
}
