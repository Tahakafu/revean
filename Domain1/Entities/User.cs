using Domain1.Commen;
using Domain1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain1.Entities
{
    public class User :BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public Enums.Enums.UserRole UserRole { get; set; } = Enums.Enums.UserRole.Customer;
        public bool IsActive { get; set; } = true;
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
