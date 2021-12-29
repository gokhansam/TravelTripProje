namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Baslik", c => c.String());
            DropColumn("dbo.Blogs", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Blogs", "Baslik");
        }
    }
}
