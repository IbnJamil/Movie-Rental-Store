namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membershipEditible : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[MemberShipTypes] ON");
        }
        
        public override void Down()
        {
        }
    }
}
