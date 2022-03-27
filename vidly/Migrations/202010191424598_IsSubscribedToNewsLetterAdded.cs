namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsSubscribedToNewsLetterAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomersName", c => c.String());
            AddColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewsLetter");
            DropColumn("dbo.Customers", "CustomersName");
        }
    }
}
