using Hotel.Business;
using Hotel.Domain;
using Hotel.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Services
{    
    public class RoomServices
    {
        private readonly RomsBusiness _romsbusiness;
        private readonly IRepository<Rooms> _roomstyperepository;

        public RoomServices(RomsBusiness romsstore, IRepository<Rooms> roomstyperepository)
        {
            _romsbusiness = romsstore;
            _roomstyperepository = roomstyperepository;
        }

        public void CreateOrEdit(Rooms roms)
        {
            _romsbusiness.RooomsValidate(roms);
        }
        public IEnumerable<Rooms> ListAllRoons()
        {
            return _roomstyperepository.Getall();
        }
        public void RoomDelete(Rooms roms)
        {
            _roomstyperepository.Delete(roms);
        }
    }
}
