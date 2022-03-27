namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'357b3946-0b88-43c8-81b4-3e9287f9d766', N'admin@vidly.com', 0, N'AC8V6Vo0KLI9MIyRJdoks8VM+HxtJqpBe+RKcz+oXxINiLM2eVFt3fzDLv2PkAaH6g==', N'5f0153fe-fef5-4b92-a5fa-a0ed5a0da403', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f4628fa-43e9-4c95-87d5-1c1e5a810a5e', N'essa@gmail.com', 0, N'AOCB15XuO1W8oaxDM4ZukqTjJnAKfbtWUkhKVeEGpOchrup/XGRLKzD5RL4n5E+Kxg==', N'22e21b69-c1e8-49ed-9bb7-e2fc5700d1df', NULL, 0, 0, NULL, 1, 0, N'essa@gmail.com')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c45c3902-e72e-4abc-9f4a-f26eb2275049', N'CanManageMovies')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'357b3946-0b88-43c8-81b4-3e9287f9d766', N'c45c3902-e72e-4abc-9f4a-f26eb2275049')");
        }

        public override void Down()
        {
        }
    }
}
