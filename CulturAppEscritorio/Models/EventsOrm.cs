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
            try
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
            catch (Exception ex)
            {
                Console.WriteLine("Error en EventsOrm SelectGlobal: " + ex.Message);
                return new List<EventsComplete>();
            }
        }

        public static Events SelectByName(string name)
        {
            try
            {
                Events _events =
                    (from events in Orm.bd.Events
                     where events.title == name && events.active == true
                     select events).FirstOrDefault();
                return _events;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en EventsOrm SelectByName: " + ex.Message);
                return null;
            }
        }

        public static Events SelectById(int id)
        {
            try
            {
                Events _events =
                    (from events in Orm.bd.Events
                     where events.id == id && events.active == true
                     select events).FirstOrDefault();
                return _events;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en EventsOrm SelectById: " + ex.Message);
                return null;
            }
        }

        public static void Delete(EventsComplete events)
        {
            try
            {
                var _event = Orm.bd.Events.FirstOrDefault(existingEvent => existingEvent.id == events.event_id);
                if (_event != null)
                {
                    _event.active = false;
                    Orm.bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en EventsOrm Delete: " + ex.Message);
            }
        }

        public static void Update(EventsComplete _eventEdit)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine("Error en EventsOrm Update: " + ex.Message);
            }
        }

        public static void Insert(Events events)
        {
            try
            {
                Orm.bd.Events.Add(events);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en EventsOrm Insert: " + ex.Message);
            }
        }
    }

}
