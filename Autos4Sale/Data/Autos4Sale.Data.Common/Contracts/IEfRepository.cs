using Autos4Sale.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Autos4Sale.Data.Common.Contracts
{
    public interface IEfRepository<T> where T : class, IDeletable
    {
        IQueryable<T> GetAll { get; }
        IQueryable<T> GetAllAndDeleted { get; }
        T GetById(object id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
