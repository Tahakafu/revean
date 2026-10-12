
using Domain1.Common;
using Domain1.Enums.Enums;

namespace Domain1.Entities
{
    public class Booking : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public Enums.BookingState BookingState { get; set; } = Enums.BookingState.Pending;
        public string? Note { get; set; } = null!;
        public User? User { get; set; } = null!;
        public Room? Room { get; set; } = null!;


    }
}
