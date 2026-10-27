using Application.Interfaces;
using Domain1.Entities;
using Infrasturcture.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain1.Enums.Enums;

namespace Infrasturcture.Repositories
{
    public class RoomRepository : GenericRepository<Room> , IRoomRepository
    {

        private readonly AppDBContext _context;

        public RoomRepository(AppDBContext context) : base(context) 
        { 
        _context = context;
        }

        public async Task<IReadOnlyList<Room>> GetAvailableRoomsAsync() {

            return await _context.Rooms.Where(h => h.RoomState == RoomState.Available).ToListAsync();
        }
    }
}
