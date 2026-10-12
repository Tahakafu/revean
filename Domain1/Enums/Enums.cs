using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain1.Enums
{
    public class Enums
    {
        public enum UserRole {
        Admin=1,
        Reception=2,
        Customer =3
        }

        public enum RoomState {
        Available=1,
        Occupied=2,
        Maintenance= 3
        }

        public enum BookingState { 
        Pending =1,
        Confirmed=2,
        CheckIn=3,
        CheckOut=4,
        Canceled= 5
        }


    }
}
