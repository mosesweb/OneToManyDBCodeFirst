using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSpeakers
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public List<EventSpeaker> EventSpeaker { get; set; }
    }
}
