namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PackingItems",
                c => new
                    {
                        PackingItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        IsPacked = c.Boolean(nullable: false),
                        TripId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PackingItemId)
                .ForeignKey("dbo.Trips", t => t.TripId, cascadeDelete: true)
                .Index(t => t.TripId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PackingItems", "TripId", "dbo.Trips");
            DropIndex("dbo.PackingItems", new[] { "TripId" });
            DropTable("dbo.PackingItems");
        }
    }
}
