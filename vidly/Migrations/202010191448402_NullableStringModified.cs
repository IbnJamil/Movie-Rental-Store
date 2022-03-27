namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableStringModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomersName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "MoviesName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "MoviesName", c => c.String());
            AlterColumn("dbo.Customers", "CustomersName", c => c.String());
        }
    }
}
