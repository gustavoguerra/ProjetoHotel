using Hotel.Domain;
using Hotel.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business
{
    public class CkBusiness
    {
        private IRepository<Rooms> _roomrepository;

        public CkBusiness(IRepository<Rooms> roomreposotory)
        {
            _roomrepository = roomreposotory;
        }
        public void CheckFreerRoom(Booking booking)
        {
            var room = _roomrepository.GetById(booking.Room.ID);

            DomainException.When(room.Quantity - room.LockQuant > 0, "Quantide de quarto indisponivel para reserva !!");
        }
        public double CheckValueDiscount(Booking booking)
        {
            return 0.00;
        }
    }
}
