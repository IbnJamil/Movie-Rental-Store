namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberShipCatagoryAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "MemberShipCatagory", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "MemberShipCatagory");
        }
    }
}
