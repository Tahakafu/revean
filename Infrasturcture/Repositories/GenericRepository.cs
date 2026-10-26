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
   




    public class GenericRepository<T> : IGenericRepository<T> where T: BaseEntity
    {

        private readonly AppDBContext _context;
        GenericRepository(AppDBContext context) {
         _context = context;

        
        }

    }

}
