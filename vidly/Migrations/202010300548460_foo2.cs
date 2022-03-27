namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
                INSERT INTO [dbo].[Genres] ([Id], [GenreName]) VALUES (1, 'Drama')");
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
                INSERT INTO [dbo].[Genres] ([Id], [GenreName]) VALUES (2, 'Comedy')");
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
                INSERT INTO [dbo].[Genres] ([Id], [GenreName]) VALUES (3, 'Action')");
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
                INSERT INTO [dbo].[Genres] ([Id], [GenreName]) VALUES (4, 'Thriller')");
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
                INSERT INTO [dbo].[Genres] ([Id], [GenreName]) VALUES (5, 'Romance')");
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
                INSERT INTO [dbo].[Genres] ([Id], [GenreName]) VALUES (6, 'Entertainment')");
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
                INSERT INTO [dbo].[Genres] ([Id], [GenreName]) VALUES (7, 'Season')");
            Sql(@"SET IDENTITY_INSERT [dbo].[Genres] ON
                INSERT INTO [dbo].[Genres] ([Id], [GenreName]) VALUES (8, 'Series')");
        }
        
        public override void Down()
        {
        }
    }
}
