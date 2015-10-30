namespace WaySpot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wayspot : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hold", "Person", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hold", "Person", c => c.String());
        }
    }
}
