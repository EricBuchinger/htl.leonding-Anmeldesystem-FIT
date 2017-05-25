namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyAddedCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Location_Id", "dbo.Locations");
            DropIndex("dbo.Categories", new[] { "Location_Id" });
            RenameColumn(table: "dbo.Categories", name: "Location_Id", newName: "Fk_Location");
            AlterColumn("dbo.Categories", "Fk_Location", c => c.Int(nullable: false));
            CreateIndex("dbo.Categories", "Fk_Location");
            AddForeignKey("dbo.Categories", "Fk_Location", "dbo.Locations", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Fk_Location", "dbo.Locations");
            DropIndex("dbo.Categories", new[] { "Fk_Location" });
            AlterColumn("dbo.Categories", "Fk_Location", c => c.Int());
            RenameColumn(table: "dbo.Categories", name: "Fk_Location", newName: "Location_Id");
            CreateIndex("dbo.Categories", "Location_Id");
            AddForeignKey("dbo.Categories", "Location_Id", "dbo.Locations", "Id");
        }
    }
}
