using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
