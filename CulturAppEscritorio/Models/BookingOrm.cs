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
    }
}
