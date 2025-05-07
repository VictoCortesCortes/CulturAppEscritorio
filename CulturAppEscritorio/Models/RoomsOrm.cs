using System.Collections.Generic;
using System.Linq;

namespace CulturAppEscritorio.Models
{
    public static class RoomsOrm
    {
        public static List<Rooms> SelectGlobal()
        {
            List<Rooms> _rooms =
                        (from room in Orm.bd.Rooms
                         select room).ToList();
            return _rooms;
        }

        public static void Insert(Rooms room)
        {
            Orm.bd.Rooms.Add(room);
            Orm.bd.SaveChanges();
        }

        public static void Update(Rooms room)
        {
            Rooms _room = Orm.bd.Rooms.Find(room.id);
            if (_room != null)
            {
                _room.name = room.name;
                _room.description = room.description;
                _room.size = room.size;
                Orm.bd.SaveChanges();
            }
        }
    }
}
