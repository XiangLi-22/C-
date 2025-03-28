namespace Domains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateuserinfo11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MothCastInfo", "CurrentTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MothCastInfo", "CurrentTime");
        }
    }
}
