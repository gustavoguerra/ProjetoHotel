using Hotel.Repositorys;
using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business
{
    public class BookingStore
    {
        private readonly IRepository<Booking> _bookingrepository;
        private readonly IRepository<RoomsType> _roomtayperepository;

        public BookingStore(IRepository<Booking> bookingrepository,IRepository<RoomsType> roomtyperepository)
        {
            _bookingrepository = bookingrepository;
            _roomtayperepository = roomtyperepository;
        }
        public void Store(Booking store)
        {
            var booking =_bookingrepository.GetById(store.ID);

            if(booking is null)
            {
                _bookingrepository.Save(store);
            }
            else
            {
                booking.CheckIn = store.CheckIn;
                booking.CheckOut = store.CheckOut;
                booking.HotelGuest = store.HotelGuest;
                booking.Room = store.Room;

                _bookingrepository.Save(booking);
            }
        }
        public void DeleteBooking(Booking deletestore)
        {
            var bookingdel = _bookingrepository.GetById(deletestore.ID);

            if (bookingdel != null)
            {
                _bookingrepository.Delete(bookingdel);
            }
        }
    }
}
