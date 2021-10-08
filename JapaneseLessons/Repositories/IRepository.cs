using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JapaneseLessons.Repositories
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> Get(Expression<Func<T, bool>> whereFunc);

        public Task Add(T item);
        
    }
}