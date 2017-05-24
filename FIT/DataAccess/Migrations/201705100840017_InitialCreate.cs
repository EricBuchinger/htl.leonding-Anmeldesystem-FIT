namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false, maxLength: 25),
                        PostalCode = c.String(nullable: false, maxLength: 7),
                        Street = c.String(nullable: false, maxLength: 50),
                        Number = c.String(nullable: false, maxLength: 5),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Designation = c.String(nullable: false),
                        Graphic = c.Binary(nullable: false),
                        FK_Event = c.Int(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.FK_Event, cascadeDelete: true)
                .Index(t => t.FK_Event);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        RegistrationStart = c.DateTime(nullable: false),
                        RegistrationEnd = c.DateTime(nullable: false),
                        IsLocked = c.Boolean(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FK_Event = c.Int(nullable: false),
                        FK_Company = c.Int(nullable: false),
                        FK_Location = c.Int(nullable: false),
                        FK_Presentation = c.Int(nullable: false),
                        FK_Category = c.Int(nullable: false),
                        isAccepted = c.Boolean(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.FK_Category, cascadeDelete: true)
                .ForeignKey("dbo.Companies", t => t.FK_Company, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.FK_Event, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.FK_Location, cascadeDelete: true)
                .ForeignKey("dbo.Presentations", t => t.FK_Presentation, cascadeDelete: true)
                .Index(t => t.FK_Event)
                .Index(t => t.FK_Company)
                .Index(t => t.FK_Location)
                .Index(t => t.FK_Presentation)
                .Index(t => t.FK_Category);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        ShortDescription = c.String(nullable: false, maxLength: 350),
                        FK_Address = c.Int(nullable: false),
                        FK_Contact = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Homepage = c.String(nullable: false),
                        CompanySign = c.Binary(nullable: false),
                        SubjectAreas = c.String(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.FK_Address, cascadeDelete: true)
                .ForeignKey("dbo.Contacts", t => t.FK_Contact, cascadeDelete: true)
                .Index(t => t.FK_Address)
                .Index(t => t.FK_Contact);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FK_Person = c.Int(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.FK_Person)
                .Index(t => t.FK_Person);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(nullable: false, maxLength: 25),
                        Email = c.String(nullable: false),
                        Picture = c.Binary(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        FK_Area = c.Int(nullable: false),
                        XCoordinate = c.Double(nullable: false),
                        YCoordinate = c.Double(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.FK_Area)
                .Index(t => t.FK_Area);
            
            CreateTable(
                "dbo.Presentations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(nullable: false),
                        Title = c.String(nullable: false, maxLength: 30),
                        Description = c.String(nullable: false, maxLength: 400),
                        IsAccepted = c.Boolean(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetailAllocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FK_Detail = c.Int(nullable: false),
                        FK_Booking = c.Int(nullable: false),
                        Text = c.String(nullable: false, maxLength: 30),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.FK_Booking, cascadeDelete: true)
                .ForeignKey("dbo.Details", t => t.FK_Detail, cascadeDelete: true)
                .Index(t => t.FK_Detail)
                .Index(t => t.FK_Booking);
            
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 30),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lecturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FK_Person = c.Int(nullable: false),
                        FK_Presentation = c.Int(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.FK_Person)
                .ForeignKey("dbo.Presentations", t => t.FK_Presentation, cascadeDelete: true)
                .Index(t => t.FK_Person)
                .Index(t => t.FK_Presentation);
            
            CreateTable(
                "dbo.Representatives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FK_Person = c.Int(nullable: false),
                        FK_Booking = c.Int(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.FK_Booking, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.FK_Person)
                .Index(t => t.FK_Person)
                .Index(t => t.FK_Booking);
            
            CreateTable(
                "dbo.ResourceBookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FK_Booking = c.Int(nullable: false),
                        FK_Resource = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.FK_Booking, cascadeDelete: true)
                .ForeignKey("dbo.Resources", t => t.FK_Resource, cascadeDelete: true)
                .Index(t => t.FK_Booking)
                .Index(t => t.FK_Resource);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Description = c.String(nullable: false, maxLength: 150),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResourceBookings", "FK_Resource", "dbo.Resources");
            DropForeignKey("dbo.ResourceBookings", "FK_Booking", "dbo.Bookings");
            DropForeignKey("dbo.Representatives", "FK_Person", "dbo.People");
            DropForeignKey("dbo.Representatives", "FK_Booking", "dbo.Bookings");
            DropForeignKey("dbo.Lecturers", "FK_Presentation", "dbo.Presentations");
            DropForeignKey("dbo.Lecturers", "FK_Person", "dbo.People");
            DropForeignKey("dbo.DetailAllocations", "FK_Detail", "dbo.Details");
            DropForeignKey("dbo.DetailAllocations", "FK_Booking", "dbo.Bookings");
            DropForeignKey("dbo.Bookings", "FK_Presentation", "dbo.Presentations");
            DropForeignKey("dbo.Bookings", "FK_Location", "dbo.Locations");
            DropForeignKey("dbo.Locations", "FK_Area", "dbo.Areas");
            DropForeignKey("dbo.Bookings", "FK_Event", "dbo.Events");
            DropForeignKey("dbo.Bookings", "FK_Company", "dbo.Companies");
            DropForeignKey("dbo.Companies", "FK_Contact", "dbo.Contacts");
            DropForeignKey("dbo.Contacts", "FK_Person", "dbo.People");
            DropForeignKey("dbo.Companies", "FK_Address", "dbo.Addresses");
            DropForeignKey("dbo.Bookings", "FK_Category", "dbo.Categories");
            DropForeignKey("dbo.Areas", "FK_Event", "dbo.Events");
            DropIndex("dbo.ResourceBookings", new[] { "FK_Resource" });
            DropIndex("dbo.ResourceBookings", new[] { "FK_Booking" });
            DropIndex("dbo.Representatives", new[] { "FK_Booking" });
            DropIndex("dbo.Representatives", new[] { "FK_Person" });
            DropIndex("dbo.Lecturers", new[] { "FK_Presentation" });
            DropIndex("dbo.Lecturers", new[] { "FK_Person" });
            DropIndex("dbo.DetailAllocations", new[] { "FK_Booking" });
            DropIndex("dbo.DetailAllocations", new[] { "FK_Detail" });
            DropIndex("dbo.Locations", new[] { "FK_Area" });
            DropIndex("dbo.Contacts", new[] { "FK_Person" });
            DropIndex("dbo.Companies", new[] { "FK_Contact" });
            DropIndex("dbo.Companies", new[] { "FK_Address" });
            DropIndex("dbo.Bookings", new[] { "FK_Category" });
            DropIndex("dbo.Bookings", new[] { "FK_Presentation" });
            DropIndex("dbo.Bookings", new[] { "FK_Location" });
            DropIndex("dbo.Bookings", new[] { "FK_Company" });
            DropIndex("dbo.Bookings", new[] { "FK_Event" });
            DropIndex("dbo.Areas", new[] { "FK_Event" });
            DropTable("dbo.Resources");
            DropTable("dbo.ResourceBookings");
            DropTable("dbo.Representatives");
            DropTable("dbo.Lecturers");
            DropTable("dbo.Details");
            DropTable("dbo.DetailAllocations");
            DropTable("dbo.Presentations");
            DropTable("dbo.Locations");
            DropTable("dbo.People");
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
            DropTable("dbo.Categories");
            DropTable("dbo.Bookings");
            DropTable("dbo.Events");
            DropTable("dbo.Areas");
            DropTable("dbo.Addresses");
        }
    }
}
