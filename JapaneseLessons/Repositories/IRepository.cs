using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JapaneseLessons.Repositories
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> Get(Expression<Func<T, bool>> whereFunc = null);
        public Task<T> GetFirstOrDefault(Expression<Func<T, bool>> whereFunc = null);

        public Task Add(T item);
        public Task Remove(IEnumerable<T> item);
    }
}