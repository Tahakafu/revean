
using Domain1.Commen;
using static Domain1.Enums.Enums;

namespace Domain1.Entities
{
    public class Room : BaseEntity
    {
        public string RoomNumber { get; set; } = String.Empty;
        public int Floor { get; set; }
        public string Type { get; set; } = String.Empty;
        public decimal PricePerNight { get; set; }
        public RoomState RoomState { get; set; } = RoomState.Available;
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();


    }


}
