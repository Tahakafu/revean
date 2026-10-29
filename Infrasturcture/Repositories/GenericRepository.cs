using Application.Interfaces;
using Domain1.Commen;
using Infrasturcture.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasturcture.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private readonly AppDBContext _context;
        private readonly DbSet<T> _dbSet;
      public  GenericRepository(AppDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();

        }

        public async Task<T?> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);

        public async Task<IReadOnlyList<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public void UpdateAsync(T entity) =>  _dbSet.Update(entity);

        public async Task DeleteAsync(Guid id) 
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {

              _dbSet.Remove(entity);
            }
        
        }

        public async Task SaveChangesAsync() => await  _context.SaveChangesAsync();


    }

}
