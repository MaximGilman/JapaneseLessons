using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JapaneseLessonsLibrary.Context;
using Microsoft.EntityFrameworkCore;

namespace JapaneseLessonsLibrary.Repositories
{
    public class Repository<T>:IRepository<T> where T:class
    {
        private readonly MyLessonsContext _context;

        public Repository(MyLessonsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> whereFunc = null)
        {
            IQueryable<T> items = _context.Set<T>();
            if (whereFunc == null)
                return await items.ToListAsync();
            return await items.Where(whereFunc).ToListAsync();
        }

        public async Task Add(T item)
        {
            await SetEntries(item);
        }
        
        private async Task SetEntries(T entry)
        {
            await _context.AddAsync(entry);
            await _context.SaveChangesAsync();
        }
    }
}