using System;
using System.Linq;
using Hotel.Domain;
using Hotel.Repositorys;

namespace Hotel.Business
{
    public class RomsBusiness
    {
        private readonly IRepository<Rooms> _roomstyperepository;

        public RomsBusiness(IRepository<Rooms> roomstyperepository)
        {
            _roomstyperepository = roomstyperepository;
        }

        private void Save(Rooms store)
        {
            _roomstyperepository.Save(store);
        }
        private void Update(Rooms store)
        {
            _roomstyperepository.Save(store);
        }        

        public void RooomsValidate(Rooms room)
        {
            if (room.ID > 0)
            {
                var type = _roomstyperepository.Find(x => x.Type == room.Type).Any();
                DomainException.When(type, "Room Type is Existe");

                Save(room);
            }
            else
            {
                var getroom = _roomstyperepository.GetById(room.ID);

                getroom.ID = room.ID;
                getroom.Type = room.Type;
                getroom.Quantity = room.Quantity;
                getroom.RoomPrice = room.RoomPrice;
                getroom.LockQuant = room.LockQuant;

                Update(getroom);
            }         
        }
    }
}
