namespace TravelAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeReview : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Review", "ReviewerName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Review", "ReviewerName", c => c.String(nullable: false));
        }
    }
}
