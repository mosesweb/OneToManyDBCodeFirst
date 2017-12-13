namespace EventSpeakers
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EventSpeakersContext : DbContext
    {
        // Your context has been configured to use a 'EventSpeakersContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EventSpeakers.EventSpeakersContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EventSpeakersContext' 
        // connection string in the application configuration file.
        public EventSpeakersContext()
            : base("name=EventSpeakersContext")
        {
           

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Speaker> Speakers { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventSpeaker> EventSpeakers { get; set; }
    }


}