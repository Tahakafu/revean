using Application.DTO.Room;
using Application.Interfaces;
using Domain1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class Roomservice : IRoomService
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

        public async Task<RoomResponseDTO> AddRoom(CreateRoomDTO createroomdto)  {
            if (createroomdto.PricePerNight <= 0)  throw new ArgumentException("the price per night shoud be more then zero");
            var room = new Room
            {
                RoomNumber = createroomdto.RoomNumber,
                Floor = createroomdto.Floor,
                Type = createroomdto.Type,
                PricePerNight = createroomdto.PricePerNight,
                RoomState = createroomdto.RoomState
            };
        await _RoomRepository.AddAsync(room);
            await _RoomRepository.SaveChangesAsync();
            var RoomResponseDto = new RoomResponseDTO
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                RoomState = room.RoomState
            };

            return RoomResponseDto;
        }
        public async Task UpdateRoom(Guid Id,UpdateRoomDto updateroomdto) {
         var room = await  _RoomRepository.GetByIdAsync(Id);
            if (room == null) throw new ArgumentException("user is not exist");


            room.RoomNumber = updateroomdto.RoomNumber;
            room.Floor = updateroomdto.Floor;
            room.Type = updateroomdto.Type;
            room.PricePerNight = updateroomdto.PricePerNight;
            room.RoomState = updateroomdto.RoomState;
            

            _RoomRepository.UpdateRoom(room);
            await _RoomRepository.SaveChangesAsync();
        }
        public async Task DeleteRoom(Guid id)
        {
           var room= await _RoomRepository.GetByIdAsync(id);
            if (room == null)
            {
                throw new KeyNotFoundException($"the Room with {id} is not found");
            }
            else
            {
                 _RoomRepository.DeleteRoom(room);
            }
          await  _RoomRepository.SaveChangesAsync();
        }


    }
}
