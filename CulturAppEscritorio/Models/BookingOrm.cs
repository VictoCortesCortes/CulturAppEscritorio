using System;
using System.Collections.Generic;
using System.Linq;

namespace CulturAppEscritorio.Models
{
    public class BookingComplete
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public int event_id { get; set; }
        public string event_title { get; set; }
        public int quantity { get; set; }
    }

    public static class BookingOrm
    {
        /// <summary>
        /// Obtiene todas las reservas activas de la base de datos, uniendo las tablas de usuarios y eventos.
        /// </summary>
        /// <returns>Lista de objetos <see cref="BookingComplete"/> que contienen la información de la reserva.</returns>
        public static List<BookingComplete> SelectGlobal()
        {
            try
            {
                List<BookingComplete> _bookings =
                    (from booking in Orm.bd.Booking
                     join user in Orm.bd.Users on booking.user_id equals user.id
                     join events in Orm.bd.Events on booking.event_id equals events.id
                     where booking.active == true
                     select new BookingComplete
                     {
                         user_id = user.id,
                         user_name = user.name,
                         event_id = events.id,
                         event_title = events.title,
                         quantity = booking.quantity
                     }).ToList();
                return _bookings;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm SelectGlobal: " + ex.Message);
                return new List<BookingComplete>();
            }
        }

        /// <summary>
        /// Obtiene todas las reservas activas de un evento específico.
        /// </summary>
        /// <param name="event_id">ID del evento para el cual se desean obtener las reservas.</param>
        /// <returns>Lista de objetos <see cref="BookingComplete"/> con las reservas del evento especificado.</returns>
        public static List<BookingComplete> SelectByEvent(int event_id)
        {
            try
            {
                List<BookingComplete> _bookings =
                    (from booking in Orm.bd.Booking
                     join user in Orm.bd.Users on booking.user_id equals user.id
                     join events in Orm.bd.Events on booking.event_id equals events.id
                     where booking.event_id == event_id && booking.active == true
                     select new BookingComplete
                     {
                         user_id = user.id,
                         user_name = user.name,
                         event_id = events.id,
                         event_title = events.title,
                         quantity = booking.quantity
                     }).ToList();
                return _bookings;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm SelectByEvent: " + ex.Message);
                return new List<BookingComplete>();
            }
        }

        /// <summary>
        /// Obtiene una reserva específica de un usuario para un evento determinado.
        /// </summary>
        /// <param name="user_id">ID del usuario cuya reserva se desea obtener.</param>
        /// <param name="event_id">ID del evento para el cual se desea obtener la reserva.</param>
        /// <returns>Objeto <see cref="BookingComplete"/> que contiene la información de la reserva, o null si no existe.</returns>
        public static BookingComplete SelectByUserEvent(int user_id, int event_id)
        {
            try
            {
                BookingComplete _booking =
                    (from booking in Orm.bd.Booking
                     join user in Orm.bd.Users on booking.user_id equals user.id
                     join events in Orm.bd.Events on booking.event_id equals events.id
                     where booking.user_id == user_id && booking.event_id == event_id && booking.active == true
                     select new BookingComplete
                     {
                         user_id = user.id,
                         user_name = user.name,
                         event_id = events.id,
                         event_title = events.title,
                         quantity = booking.quantity
                     }).FirstOrDefault();
                return _booking;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm SelectByUserEvent: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Actualiza la cantidad de una reserva existente en la base de datos.
        /// </summary>
        /// <param name="booking">Objeto <see cref="BookingComplete"/> que contiene la información de la reserva a actualizar.</param>
        public static void Update(BookingComplete booking)
        {
            try
            {
                var _existingBooking = Orm.bd.Booking.FirstOrDefault(existingBooking => existingBooking.event_id == booking.event_id && existingBooking.user_id == booking.user_id);
                if (_existingBooking != null)
                {
                    _existingBooking.quantity = booking.quantity;
                    Orm.bd.SaveChanges();  // Guarda los cambios en la base de datos
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm Update: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina una reserva estableciendo su estado como inactivo.
        /// </summary>
        /// <param name="booking">Objeto <see cref="BookingComplete"/> que representa la reserva a eliminar.</param>
        public static void Delete(BookingComplete booking)
        {
            try
            {
                var _booking = Orm.bd.Booking.FirstOrDefault(existingBooking => existingBooking.event_id == booking.event_id && existingBooking.user_id == booking.user_id);
                if (_booking != null)
                {
                    _booking.active = false;  // Marca la reserva como inactiva
                    Orm.bd.SaveChanges();  // Guarda los cambios en la base de datos
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm Delete: " + ex.Message);
            }
        }

        /// <summary>
        /// Inserta una nueva reserva en la base de datos.
        /// </summary>
        /// <param name="booking">Objeto <see cref="Booking"/> que contiene la información de la nueva reserva.</param>
        public static void Insert(Booking booking)
        {
            try
            {
                Orm.bd.Booking.Add(booking);  // Agrega la nueva reserva
                Orm.bd.SaveChanges();  // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm Insert: " + ex.Message);
            }
        }
    }
}
