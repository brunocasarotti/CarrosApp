﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace CarsCollectors.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T TEntity);
        void Update(T TEntity);
        void Remove(T TEntity);
        void Save();
        void Dispose();
    }
}
