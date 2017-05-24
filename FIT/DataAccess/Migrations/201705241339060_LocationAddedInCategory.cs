namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocationAddedInCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Location_Id", c => c.Int());
            CreateIndex("dbo.Categories", "Location_Id");
            AddForeignKey("dbo.Categories", "Location_Id", "dbo.Locations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Location_Id", "dbo.Locations");
            DropIndex("dbo.Categories", new[] { "Location_Id" });
            DropColumn("dbo.Categories", "Location_Id");
        }
    }
}
