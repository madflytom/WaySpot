namespace WaySpot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hold",
                c => new
                    {
                        HoldID = c.Int(nullable: false, identity: true),
                        Person = c.String(),
                        HoldDateTime = c.DateTime(nullable: false),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.HoldID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hold");
        }
    }
}
