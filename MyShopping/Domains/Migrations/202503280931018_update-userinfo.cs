namespace Domains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateuserinfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MothCastInfo", "SkincarePrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "HousePrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "TranPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "EntertainmentPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "MedicalPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "CommunicaPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "SportPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "SocialPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "RelationshipPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "PetPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "LotteryPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "CarPrice", c => c.Single(nullable: false));
            AddColumn("dbo.MothCastInfo", "ParenPrice", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MothCastInfo", "ParenPrice");
            DropColumn("dbo.MothCastInfo", "CarPrice");
            DropColumn("dbo.MothCastInfo", "LotteryPrice");
            DropColumn("dbo.MothCastInfo", "PetPrice");
            DropColumn("dbo.MothCastInfo", "RelationshipPrice");
            DropColumn("dbo.MothCastInfo", "SocialPrice");
            DropColumn("dbo.MothCastInfo", "SportPrice");
            DropColumn("dbo.MothCastInfo", "CommunicaPrice");
            DropColumn("dbo.MothCastInfo", "MedicalPrice");
            DropColumn("dbo.MothCastInfo", "EntertainmentPrice");
            DropColumn("dbo.MothCastInfo", "TranPrice");
            DropColumn("dbo.MothCastInfo", "HousePrice");
            DropColumn("dbo.MothCastInfo", "SkincarePrice");
        }
    }
}
