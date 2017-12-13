using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSpeakers
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public string SpeakerName { get; set; }
        public List<EventSpeaker> EventSpeaker { get; set; }
    }
}
