using System;
using System.Collections.Generic;
using System.Linq;

namespace CulturAppEscritorio.Models
{
    public static class RoomsOrm
    {
        public static List<Rooms> SelectGlobal()
        {
            try
            {
                List<Rooms> _rooms =
                    (from room in Orm.bd.Rooms
                     select room).ToList();
                return _rooms;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en RoomsOrm SelectGlobal: " + ex.Message);
                return new List<Rooms>();
            }
        }

        public static Rooms SelectByName(string name)
        {
            try
            {
                Rooms _rooms =
                    (from room in Orm.bd.Rooms
                     where room.name == name
                     select room).FirstOrDefault();
                return _rooms;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en RoomsOrm SelectByName: " + ex.Message);
                return null;
            }
        }

        public static void Insert(Rooms room)
        {
            try
            {
                Orm.bd.Rooms.Add(room);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en RoomsOrm Insert: " + ex.Message);
            }
        }

        public static void Update(Rooms room)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine("Error en RoomsOrm Update: " + ex.Message);
            }
        }
    }

}
