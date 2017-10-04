using System.Linq;
using Autos4Sale.Data.Models;

namespace Autos4Sale.Services.Contracts
{
    public interface ICarOffersService
    {
        IQueryable<CarOffer> GetAll();
    }
}