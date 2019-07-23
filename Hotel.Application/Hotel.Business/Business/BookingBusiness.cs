using Hotel.Repositorys;
using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business
{
    public class BookingBusiness
    {
        private readonly IRepository<Booking> _bookingrepository;
        private readonly CkBusiness _ckbooking;

        public BookingBusiness(IRepository<Booking> bookingrepository, CkBusiness ckbooking)
        {
            _bookingrepository = bookingrepository;
            _ckbooking = ckbooking;
        }

        private void Save(Booking store)
        {
            _bookingrepository.Save(store);
        }

        private void update(Booking store)
        {
            _bookingrepository.Update(store);
        }

        public void BookingStore(Booking booking)
        {
            _ckbooking.CheckFreerRoom(booking);

            if (booking.ID >= 0)
                update(booking);
            else
                Save(booking);
        }
    }
}
