using System;
using System.Collections.Generic;
using System.Linq;

namespace CulturAppEscritorio.Models
{
    public static class RoomsOrm
    {
        /// <summary>
        /// Obtiene todas las habitaciones de la base de datos.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Rooms"/> que representan las habitaciones en la base de datos.</returns>
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
                return new List<Rooms>();  // Retorna una lista vacía en caso de error
            }
        }

        /// <summary>
        /// Obtiene una habitación por su nombre.
        /// </summary>
        /// <param name="name">El nombre de la habitación a buscar.</param>
        /// <returns>Un objeto <see cref="Rooms"/> que representa la habitación, o null si no se encuentra.</returns>
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

        /// <summary>
        /// Inserta una nueva habitación en la base de datos.
        /// </summary>
        /// <param name="room">El objeto <see cref="Rooms"/> que contiene los datos de la habitación a insertar.</param>
        public static void Insert(Rooms room)
        {
            try
            {
                Orm.bd.Rooms.Add(room);  // Agrega la nueva habitación
                Orm.bd.SaveChanges();  // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en RoomsOrm Insert: " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza los detalles de una habitación existente en la base de datos.
        /// </summary>
        /// <param name="room">El objeto <see cref="Rooms"/> con los datos actualizados de la habitación.</param>
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
                    Orm.bd.SaveChanges();  // Guarda los cambios en la base de datos
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en RoomsOrm Update: " + ex.Message);
            }
        }
    }
}
