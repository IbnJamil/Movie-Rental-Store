namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class avilibiltyAddedToMovies1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Aviliability", c => c.Int(nullable: false));
            Sql("UPDATE Movies SET Aviliability=NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Aviliability");
        }
    }
}
