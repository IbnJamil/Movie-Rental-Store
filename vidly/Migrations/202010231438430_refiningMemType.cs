namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refiningMemType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberShipTypes", "SignUpFee", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberShipTypes", "SignUpFee", c => c.Byte(nullable: false));
        }
    }
}
