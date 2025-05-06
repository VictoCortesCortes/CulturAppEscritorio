using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturAppEscritorio.Models
{
    public class EventsComplete
    {
        public int event_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int capacity { get; set; }
        public int price { get; set; }
        public int type_id { get; set; }
        public string type { get; set; }
        public int room_id { get; set; }
        public string room { get; set; }
    }
    public static class EventsOrm
    {
        public static List<EventsComplete> SelectGlobal()
        {
            List<EventsComplete> _events =
                        (from events in Orm.bd.Events
                         join type in Orm.bd.Type_event on events.type_id equals type.id
                         join room in Orm.bd.Rooms on events.room_id equals room.id
                         select new EventsComplete
                         {
                             event_id = events.id,
                             title = events.title,
                             description = events.description,
                             start_date = events.start_datetime,
                             end_date = events.end_datetime,
                             capacity = events.capacity,
                             price = events.price,
                             type_id = type.id,
                             type = type.name,
                             room_id = room.id,
                             room = room.name
                         }).ToList();
            return _events;
        }
    }
}
