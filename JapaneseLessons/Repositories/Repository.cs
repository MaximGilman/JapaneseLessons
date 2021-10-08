using JapaneseLessons.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JapaneseLessons.Models;

namespace JapaneseLessons.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public Repository()
        {
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> whereFunc = null)
        {
            await using var context = new MyLessonsContext();
            IQueryable<T> items = context.Set<T>();
            if (whereFunc == null)
                return await items.ToListAsync();
            return await items.Where(whereFunc).ToListAsync();
        }

        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> whereFunc = null)
        {
            await using var context = new MyLessonsContext();
            IQueryable<T> items = context.Set<T>();
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
            await using var context = new MyLessonsContext();

            await context.AddAsync(entry);
            await context.SaveChangesAsync();
        }

        public async Task Remove(IEnumerable<T> entities)
        {
            await using var context = new MyLessonsContext();
            context.RemoveRange(entities);
        }
    }
}