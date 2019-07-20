using Hotel.Domain;
using Hotel.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business
{
    public class LockRoomStore
    {
        private readonly IRepository<LockRoom> _lockroomrepository;

        public LockRoomStore(IRepository<LockRoom> lockroomrepository)
        {
            _lockroomrepository = lockroomrepository;
        }

        public void store(LockRoom store)
        {
            var room = _lockroomrepository.GetById(store.ID);

            if(room is null) // New
            {
                _lockroomrepository.Save(store);
            }
            else // Update
            {
                room.Room = store.Room;
                room.Quantity = store.Quantity;

                _lockroomrepository.Save(room);
            }
        }

    }
}
