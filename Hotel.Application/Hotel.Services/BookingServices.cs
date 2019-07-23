using Hotel.Business;
using Hotel.Domain;
using Hotel.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Services
{
    public class BookingServices
    {
        private readonly IRepository<Booking> _bookingrepository;
        
        private readonly BookingBusiness _bookingstore;

        public BookingServices(IRepository<Booking> boockingrepository, BookingBusiness boockingstore)
        {
            _bookingrepository = boockingrepository;
            _bookingstore = boockingstore;
        }

        public void CreateOrEdit(Booking store)
        {
            _bookingstore.BookingValidate(store);
        }

        public IEnumerable<Booking> ListAllBooking()
        {
            return _bookingrepository.Getall();
        }
        public void DeleteBoking(Booking booking)
        {
            _bookingrepository.Delete(booking);
        }
    }
}
