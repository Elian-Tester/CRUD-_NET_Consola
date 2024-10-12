using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpCodeChallenge.DBConnections;
using Microsoft.EntityFrameworkCore;

namespace CsharpCodeChallenge.Persistence.Repository
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly ContextDb _context;
        private readonly DbSet<T> _dbset;

        public Repository(ContextDb context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }
        public async Task CreateAsync(T entity)
        {
            await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            var keyName = _context.Model
                .FindEntityType(typeof(T))
                .FindPrimaryKey().Properties
                .Select(x => x.Name).Single();

            var trackedEntity = _context.ChangeTracker.Entries<T>()
                .FirstOrDefault(e => e.Property(keyName).CurrentValue.Equals(entity.GetType().GetProperty(keyName).GetValue(entity)));

            if (trackedEntity == null)
            {
                _context.Set<T>().Update(entity);
            }
            else{
                trackedEntity.CurrentValues.SetValues(entity);
            }
            
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbset.FindAsync(id);
            if(entity != null)
            {
                _dbset.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

    }
}
