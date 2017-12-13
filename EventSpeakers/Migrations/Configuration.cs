namespace EventSpeakers.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EventSpeakers.EventSpeakersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EventSpeakersContext context)
        {
            Speaker speakerDonald = new Speaker { SpeakerName = "Donald Trump" };
            Speaker speakerElonMusk = new Speaker { SpeakerName = "Elon Musk" };
            Speaker speakerBillGates = new Speaker { SpeakerName = "Bill Gates" };
            
            Event trumpRally = new Event { EventName = "Trump Rally" };
            Event techMeeting = new Event { EventName = "Tech Conference" };
            
            context.Events.AddOrUpdate(e => e.EventName, trumpRally);
            context.Events.AddOrUpdate(e => e.EventName, techMeeting);

            context.EventSpeakers.Add(new EventSpeaker { Speaker = speakerBillGates, Event = techMeeting });
            context.EventSpeakers.Add(new EventSpeaker { Speaker = speakerDonald, Event = techMeeting });
            context.EventSpeakers.Add(new EventSpeaker { Speaker = speakerElonMusk, Event = techMeeting });

            context.EventSpeakers.Add(new EventSpeaker { Speaker = speakerDonald, Event = trumpRally });
            context.SaveChanges();
        }
    }
}
