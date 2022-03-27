namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipenumAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypesId", "dbo.MemberShipTypes");
            DropPrimaryKey("dbo.MemberShipTypes");
            AlterColumn("dbo.MemberShipTypes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.MemberShipTypes", "Id");
            AddForeignKey("dbo.Customers", "MemberShipTypesId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypesId", "dbo.MemberShipTypes");
            DropPrimaryKey("dbo.MemberShipTypes");
            AlterColumn("dbo.MemberShipTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MemberShipTypes", "Id");
            AddForeignKey("dbo.Customers", "MemberShipTypesId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
    }
}
