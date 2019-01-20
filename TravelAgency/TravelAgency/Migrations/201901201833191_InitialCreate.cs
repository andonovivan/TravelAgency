namespace TravelAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        VacationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Vacations", t => t.VacationId, cascadeDelete: true)
                .Index(t => t.VacationId);
            
            CreateTable(
                "dbo.Vacations",
                c => new
                    {
                        VacationId = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        Continent = c.String(nullable: false),
                        ShortDescription = c.String(nullable: false),
                        LongDescription = c.String(nullable: false),
                        ImageUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.VacationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "VacationId", "dbo.Vacations");
            DropIndex("dbo.Reviews", new[] { "VacationId" });
            DropTable("dbo.Vacations");
            DropTable("dbo.Reviews");
        }
    }
}
