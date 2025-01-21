namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "Budget", c => c.Double(nullable: false));
            AddColumn("dbo.Trips", "ActualExpense", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "ActualExpense");
            DropColumn("dbo.Trips", "Budget");
        }
    }
}
