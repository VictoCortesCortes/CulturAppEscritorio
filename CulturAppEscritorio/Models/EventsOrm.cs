using System;
using System.Collections.Generic;
using System.Linq;

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
                         where events.active == true
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

        public static Events SelectByName(string name)
        {
            Events _events =
                        (from events in Orm.bd.Events
                         where events.title == name && events.active == true
                         select events).FirstOrDefault();
            return _events;
        }

        public static Events SelectById(int id)
        {
            Events _events =
                        (from events in Orm.bd.Events
                         where events.id == id && events.active == true
                         select events).FirstOrDefault();
            return _events;
        }

        public static void Delete(EventsComplete events)
        {
            var _event = Orm.bd.Events.FirstOrDefault(existingEvent => existingEvent.id == events.event_id);
            if (events != null)
            {
                _event.active = false;
                Orm.bd.SaveChanges();
            }
        }

        public static void Update(EventsComplete _eventEdit)
        {
            var _event = Orm.bd.Events.FirstOrDefault(existingEvent => existingEvent.id == _eventEdit.event_id);
            if (_event != null)
            {
                _event.title = _eventEdit.title;
                _event.description = _eventEdit.description;
                _event.start_datetime = _eventEdit.start_date;
                _event.end_datetime = _eventEdit.end_date;
                _event.capacity = _eventEdit.capacity;
                _event.price = _eventEdit.price;
                _event.type_id = _eventEdit.type_id;
                _event.room_id = _eventEdit.room_id;
                Orm.bd.SaveChanges();
            }
        }

        public static void Insert(Events events)
        {
            Orm.bd.Events.Add(events);
            Orm.bd.SaveChanges();
        }
    }
}
