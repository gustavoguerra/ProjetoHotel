using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain
{
    public class LockRoom : Entity
    {
        public RoomsType Room { get; set; }

        public int Quantity { get; set; }
    }
}
