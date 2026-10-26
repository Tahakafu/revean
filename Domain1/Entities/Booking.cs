
using Domain1.Commen;
using static Domain1.Enums.Enums;


namespace Domain1.Entities
{
    public class Booking : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid RoomId { get; set; }
        public DateTime CheckInDate { get; set; } = DateTime.UtcNow;
        public DateTime CheckOutDate { get; set; } = DateTime.UtcNow;
        public decimal TotalPrice { get; set; }
        public BookingState BookingState { get; set; } = BookingState.Pending;
        public string? Note { get; set; } = null!;
        public User? User { get; set; } = null!;
        public Room? Room { get; set; } = null!;


    }
}
