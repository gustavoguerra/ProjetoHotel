using System;
using System.Linq;
using Hotel.Domain;
using Hotel.Repositorys;

namespace Hotel.Business
{
    public class RomsStore
    {
        private readonly IRepository<Rooms> _roomstyperepository;

        public RomsStore(IRepository<Rooms> roomstyperepository)
        {
            _roomstyperepository = roomstyperepository;
        }

        public void Store(Rooms store)
        {           
            var room = _roomstyperepository.GetById(store.ID);

            if (room is null) //Save
            {
                var type = _roomstyperepository.Find(x => x.Type == store.Type).Any();

                DomainException.When(type, "Room Type is Existe");

                _roomstyperepository.Save(store);
            }
            else //Update
            {
                room.ID = store.ID;
                room.Type = store.Type;
                room.Quantity = store.Quantity;
                room.RoomPrice = store.RoomPrice;
                room.LockQuant = store.LockQuant;

                _roomstyperepository.Save(room);
            }
        }
       
        
    }
}
