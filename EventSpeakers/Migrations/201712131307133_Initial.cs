namespace EventSpeakers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.EventSpeakers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        SpeakerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Speakers", t => t.SpeakerId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.SpeakerId);
            
            CreateTable(
                "dbo.Speakers",
                c => new
                    {
                        SpeakerId = c.Int(nullable: false, identity: true),
                        SpeakerName = c.String(),
                    })
                .PrimaryKey(t => t.SpeakerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventSpeakers", "SpeakerId", "dbo.Speakers");
            DropForeignKey("dbo.EventSpeakers", "EventId", "dbo.Events");
            DropIndex("dbo.EventSpeakers", new[] { "SpeakerId" });
            DropIndex("dbo.EventSpeakers", new[] { "EventId" });
            DropTable("dbo.Speakers");
            DropTable("dbo.EventSpeakers");
            DropTable("dbo.Events");
        }
    }
}
