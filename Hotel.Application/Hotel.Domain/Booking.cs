using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain
{
    public class Booking : Entity
    {
        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public string HotelGuest { get; set; }

        public RoomsType Room { get; set; } 
        
    }
}
