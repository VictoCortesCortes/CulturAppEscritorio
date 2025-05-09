using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void Update(BookingComplete booking)
        {
            try
            {
                var _existingBooking = Orm.bd.Booking.FirstOrDefault(existingBooking => existingBooking.event_id == booking.event_id && existingBooking.user_id == booking.user_id);
                if (_existingBooking != null)
                {
                    _existingBooking.quantity = booking.quantity;
                    Orm.bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm Update: " + ex.Message);
            }
        }

        public static void Delete(BookingComplete booking)
        {
            try
            {
                var _booking = Orm.bd.Booking.FirstOrDefault(existingBooking => existingBooking.event_id == booking.event_id && existingBooking.user_id == booking.user_id);
                if (_booking != null)
                {
                    _booking.active = false;
                    Orm.bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm Delete: " + ex.Message);
            }
        }

        public static void Insert(Booking booking)
        {
            try
            {
                Orm.bd.Booking.Add(booking);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BookingOrm Insert: " + ex.Message);
            }
        }
    }

}
