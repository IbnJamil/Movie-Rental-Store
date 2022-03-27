namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membershiptableremoved : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypesId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypesId" });
            DropColumn("dbo.Customers", "MemberShipTypesId");
            DropTable("dbo.MemberShipTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                        MemberShipCatagory = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberShipTypesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipTypesId");
            AddForeignKey("dbo.Customers", "MemberShipTypesId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
    }
}
