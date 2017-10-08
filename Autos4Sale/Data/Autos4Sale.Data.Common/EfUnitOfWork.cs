using Autos4Sale.Data.Common.Contracts;
using System.Data.Entity;

namespace Autos4Sale.Data.Common
{
    public class EfUnitOfWork : IEfUnitOfWork
    {
        private readonly Autos4SaleDbContext dbContext;

        public EfUnitOfWork(Autos4SaleDbContext dbcontext)
        {
            this.dbContext = dbcontext;
        }

        public void Commit()
        {
            this.dbContext.SaveChanges();
        }
    }
}
