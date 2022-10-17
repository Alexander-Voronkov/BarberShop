namespace CodeFirstFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Archives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Record_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.Record_Id, cascadeDelete: true)
                .Index(t => t.Record_Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Client_Id = c.Int(nullable: false),
                        Service_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.Service_Id, cascadeDelete: true)
                .Index(t => t.Client_Id)
                .Index(t => t.Service_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Feedback = c.String(nullable: false, maxLength: 500),
                        HowGood = c.String(nullable: false, maxLength: 20),
                        Barber_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.Barber_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Barber_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Barbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 20),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                        BirthDate = c.DateTime(nullable: false),
                        DateOfAcception = c.DateTime(nullable: false),
                        Position = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(nullable: false, maxLength: 100),
                        Duration = c.Time(nullable: false, precision: 7),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Barber_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.Barber_Id, cascadeDelete: true)
                .Index(t => t.Barber_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Archives", "Record_Id", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Schedules", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Feedbacks", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Feedbacks", "Barber_Id", "dbo.Barbers");
            DropForeignKey("dbo.Services", "Barber_Id", "dbo.Barbers");
            DropIndex("dbo.Services", new[] { "Barber_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Client_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Barber_Id" });
            DropIndex("dbo.Schedules", new[] { "Service_Id" });
            DropIndex("dbo.Schedules", new[] { "Client_Id" });
            DropIndex("dbo.Archives", new[] { "Record_Id" });
            DropTable("dbo.Services");
            DropTable("dbo.Barbers");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Clients");
            DropTable("dbo.Schedules");
            DropTable("dbo.Archives");
        }
    }
}
