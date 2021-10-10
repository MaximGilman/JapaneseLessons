using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JapaneseLibrary.Context;
using Microsoft.EntityFrameworkCore;

namespace JapaneseLibrary.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MyLessonsContext _ctx;

        public Repository(MyLessonsContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> whereFunc = null)
        {
            IQueryable<T> items = _ctx.Set<T>();
            if (whereFunc == null)
                return await items.ToListAsync();
            return await items.Where(whereFunc).ToListAsync();
        }

        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> whereFunc = null)
        {
            IQueryable<T> items = _ctx.Set<T>();
            if (whereFunc == null)
                return await items.FirstOrDefaultAsync();
            return await items.Where(whereFunc).FirstOrDefaultAsync();
        }

        public async Task Add(T item)
        {
            await SetEntries(item);
        }

        private async Task SetEntries(T entry)
        {
            await _ctx.AddAsync(entry);
            await _ctx.SaveChangesAsync();
        }

        public async Task Remove(IEnumerable<T> entities)
        {
            _ctx.RemoveRange(entities);
        }
    }
}