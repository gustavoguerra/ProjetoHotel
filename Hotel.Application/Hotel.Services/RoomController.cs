using Hotel.Business;
using Hotel.Domain;
using Hotel.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Services
{    
    public class RoomController
    {
        private readonly RomsStore _romsstore;
        private readonly IRepository<Rooms> _roomstyperepository;

        public RoomController(RomsStore romsstore, IRepository<Rooms> roomstyperepository)
        {
            _romsstore = romsstore;
            _roomstyperepository = roomstyperepository;
        }

        public void CreateOrEdit(string id,string roomtype,string Quantity, string price, string lockquant)
        {
            var room = new Rooms();

            room.ID = Convert.ToInt32(id);
            room.Type = roomtype;
            room.Quantity = Convert.ToInt32(Quantity);
            room.RoomPrice = Convert.ToDouble(price);
            room.LockQuant = Convert.ToInt32(lockquant);

            _romsstore.Store(room);
        }
        public IEnumerable<Rooms> ListAllRoons()
        {
            return _roomstyperepository.Getall();
        }
    }
}
