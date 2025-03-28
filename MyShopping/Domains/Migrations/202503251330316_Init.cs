namespace Domains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DayCastInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoodsName = c.String(nullable: false, maxLength: 20, unicode: false),
                        GoodsType = c.Int(nullable: false),
                        GoodsPrice = c.Single(nullable: false),
                        DaysCast = c.Single(nullable: false),
                        TotalRemain = c.Single(nullable: false),
                        CurrentTime = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MothCastInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodPrice = c.Single(nullable: false),
                        ClothPrice = c.Single(nullable: false),
                        ElectricalPrice = c.Single(nullable: false),
                        DailyPrice = c.Single(nullable: false),
                        TravelPrice = c.Single(nullable: false),
                        TotalRemain = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.YearCastInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Moth = c.Int(nullable: false),
                        Cast = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YearCastInfo");
            DropTable("dbo.MothCastInfo");
            DropTable("dbo.DayCastInfo");
        }
    }
}
