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
        public string event_name { get; set; }
        public int quantity { get; set; }
    }
    public static class BookingOrm
    {
    }
}
