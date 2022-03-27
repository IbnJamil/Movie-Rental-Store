namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zipCodeFieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ZipCode");
        }
    }
}
