namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentalClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        customers_Id = c.Int(nullable: false),
                        movies_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.customers_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.movies_Id, cascadeDelete: true)
                .Index(t => t.customers_Id)
                .Index(t => t.movies_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "movies_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "customers_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "movies_Id" });
            DropIndex("dbo.Rentals", new[] { "customers_Id" });
            DropTable("dbo.Rentals");
        }
    }
}
