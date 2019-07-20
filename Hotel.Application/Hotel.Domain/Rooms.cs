using System;

namespace Hotel.Domain
{
    public class Rooms : Entity
    {
        public string Type { get; set; }

        public int Quantity { get; set; }

        public int LockQuant { get; set; }

        public double RoomPrice { get; set; }  
    }
}
