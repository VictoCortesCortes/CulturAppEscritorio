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

        public static List<BookingComplete> SelectByEvent(int event_id)
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

        public static void Update(BookingComplete booking)
        {
            var _existingBooking = Orm.bd.Booking.FirstOrDefault(existingBooking => existingBooking.event_id == booking.event_id && existingBooking.user_id == booking.user_id);
            if (_existingBooking != null)
            {
                _existingBooking.quantity = booking.quantity;
                Orm.bd.SaveChanges();
            }
        }

        public static void Delete(BookingComplete booking)
        {
            var _booking = Orm.bd.Booking.FirstOrDefault(existingBooking => existingBooking.event_id == booking.event_id && existingBooking.user_id == booking.user_id);
            if (_booking != null)
            {
                _booking.active = false;
                Orm.bd.SaveChanges();
            }
        }
        public static void Insert(Booking booking)
        {
            Orm.bd.Booking.Add(booking);
            Orm.bd.SaveChanges();
        }
    }
}
