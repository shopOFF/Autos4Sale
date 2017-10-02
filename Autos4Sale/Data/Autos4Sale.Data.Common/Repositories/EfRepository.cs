using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.Data.Common.Repositories
{
    public class EfRepository<T> : IEfRepository<T>
        where T : class, IDeletable
    {
        private readonly DbContext dbContext;

        public EfRepository(DbContext dbcontext)
        {
            this.dbContext = dbcontext;
        }

        public IQueryable<T> All
        {
            get
            {
                return this.dbContext.Set<T>().Where(x => !x.IsDeleted);
            }
        }

        public IQueryable<T> AllAndDeleted
        {
            get
            {
                return this.dbContext.Set<T>();
            }
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.dbContext.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.dbContext.Set<T>().Add(entity);
            }
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;

            var entry = this.dbContext.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public void Update(T entity)
        {
            DbEntityEntry entry = this.dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.dbContext.Set<T>().Attach(entity);
            }

            entry.State = EntityState.Modified;
        }
    }
}
