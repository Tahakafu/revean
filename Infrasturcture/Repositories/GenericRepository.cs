using Infrasturcture.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasturcture.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDBContext _context;
        protected readonly DbSet<T> _dbset;
        GenericRepository(AppDBContext context) { 
        
            _context = context;
            _dbset = context.Set<T>();
        }


        public async Task<T?> GetByIdAsync(Guid id) {
        
        return  _dbset.FirstOrDefaultAsync( g => g.id==id&& !g.isdelted);
        }


       sumation(int x, int y) {
        
        return x+y;
        
        }
       

        Car c = new car

            c.id
            c.name
            c.drive();

        (int x , int y)  => x+y;
            



        int main() {
        
        sumation(1, 2);
        
        }







    }
}
