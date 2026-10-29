using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain1.Enums.Enums;

namespace Application.DTO.Room
{
    public class RoomResponseDto
    {
        public Guid Id { get; set; }  
        public string RoomNumber { get; set; }
        public decimal PricePerNight { get; set; }
        public RoomState RoomState { get; set; }
    }
}
