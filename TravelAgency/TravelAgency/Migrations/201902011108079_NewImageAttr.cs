namespace TravelAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewImageAttr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vacation", "ImageUrlDetailed", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vacation", "ImageUrlDetailed");
        }
    }
}
