namespace Domains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MothCastInfo", "RefundMoney", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MothCastInfo", "RefundMoney");
        }
    }
}
