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
    }
}
