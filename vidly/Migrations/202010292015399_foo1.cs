namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON");
        }
        
        public override void Down()
        {
        }
    }
}
