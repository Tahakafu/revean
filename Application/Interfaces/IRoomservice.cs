using Application.DTO.Room;
using Domain1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRoomService
    {

        public Task<Room> GetRoomByid(Guid id);
        public Task<IReadOnlyList<Room>> GetALLRooms();
        public Task<RoomResponseDto> AddRoom(CreateRoomDto ceateroomdto);
        public void UpdateRoom(Room room);  
        public Task DeleteRoom(Guid id);

    }
}
