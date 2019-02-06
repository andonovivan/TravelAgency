namespace TravelAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Review",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(nullable: false),
                        ReviewerName = c.String(nullable: false),
                        VacationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Vacation", t => t.VacationId, cascadeDelete: true)
                .Index(t => t.VacationId);
            
            CreateTable(
                "dbo.Vacation",
                c => new
                    {
                        VacationId = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        Continent = c.String(nullable: false),
                        ShortDescription = c.String(nullable: false),
                        LongDescription = c.String(nullable: false),
                        ImageUrl = c.String(nullable: false),
                        ImageUrlDetailed = c.String(),
                    })
                .PrimaryKey(t => t.VacationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Review", "VacationId", "dbo.Vacation");
            DropIndex("dbo.Review", new[] { "VacationId" });
            DropTable("dbo.Vacation");
            DropTable("dbo.Review");
        }
    }
}
