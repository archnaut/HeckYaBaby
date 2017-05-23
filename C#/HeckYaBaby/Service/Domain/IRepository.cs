using System;
using System.Linq;
using System.Linq.Expressions;

namespace Service.Domain
{
    internal interface IRepository
    {
        void Add<T>(T item) where T : class;
        IQueryable<T> AllInstances<T>() where T : class;
        T Get<T>(Expression<Func<T, bool>> predicate) where T : class;
        IUnitOfWork NewUnitOfWork();
        void Remove<T>(Expression<Func<T, bool>> predicate) where T : class;
        void Remove<T>(T item) where T : class;
        int Update<T>(Expression<Func<T, bool>> predicate, Expression<Func<T, T>> map) where T : class;
    }
}