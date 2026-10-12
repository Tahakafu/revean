using Domain1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain1.Enums;

namespace Domain1.Entities
{
    public class Room : BaseEntity
    {
        public string RoomNumber { get; set; } = String.Empty;
        public int Floor { get; set; }
        public string Type { get; set; } = String.Empty;
        public decimal PricePerNight { get; set; }
        public Enums.Enums.RoomState RoomState { get; set; } = Enums.Enums.RoomState.Available;
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();


    }
}
