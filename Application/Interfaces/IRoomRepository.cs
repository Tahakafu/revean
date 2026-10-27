using Domain1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRoomRepository : IGenericRepository<Room>
    {
        public Task<IReadOnlyList<Room>> GetAvailableRoomsAsync();
        

    }
}
