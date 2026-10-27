using Domain1.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericRepository <T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(Guid Id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task AddAsync(T entity);
        void UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
