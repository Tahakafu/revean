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

        public Task<RoomResponseDTO> GetRoomByid(Guid id);
        public Task<IReadOnlyList<RoomResponseDTO>> GetALLRooms();
        public Task<RoomResponseDTO> AddRoom(CreateRoomDTO ceateroomdto);
        public  Task UpdateRoom(Guid Id,UpdateRoomDto updateroomdto);  
        public Task DeleteRoom(Guid id);

    }
}
