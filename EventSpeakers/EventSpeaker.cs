using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSpeakers
{
    public class EventSpeaker
    {
        public int Id { get; set; }

        public Event Event { get; set; }
        public int EventId { get; set; }

        public Speaker Speaker { get; set; }
        public int SpeakerId { get; set; }
    }
}
