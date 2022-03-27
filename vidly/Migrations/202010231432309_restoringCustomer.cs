namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restoringCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MemberShipTypesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipTypesId");
            AddForeignKey("dbo.Customers", "MemberShipTypesId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypesId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypesId" });
            DropColumn("dbo.Customers", "MemberShipTypesId");
        }
    }
}
