using Domain1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRoomservice
    {

        public Task<Room> GetRoomByid(Guid id);
        public Task<IReadOnlyList<Room>> GetALLRooms();
        public Task AddRoom(Room room);
        public void UpdateRoom(Room room);  
        public Task DeleteRoom(Guid id);

    }
}
