using Application.Interfaces;
using Domain1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class Roomservice : IRoomservice
    {
       private readonly IRoomRepository _RoomRepository;
        public Roomservice(IRoomRepository RoomRepository) {
            _RoomRepository = RoomRepository;
        }

        public async Task<Room> GetRoomByid(Guid id) {
          return await  _RoomRepository.GetByIdAsync(id);
        
        }
        public async Task<IReadOnlyList<Room>> GetALLRooms() { 
        
        return await _RoomRepository.GetAllAsync();
        }

        public async Task AddRoom(Room room)  { 
        await _RoomRepository.AddAsync(room);
        }
        public void UpdateRoom(Room room) {
            _RoomRepository.UpdateAsync(room);
        }
        public void DeleteRoom(Guid id)
        {
            _RoomRepository.DeleteAsync(id);
        }

    }
}
