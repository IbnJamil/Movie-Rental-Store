namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes VALUES(0,0,0)");
            Sql("INSERT INTO MemberShipTypes VALUES(30,1,10)");
            Sql("INSERT INTO MemberShipTypes VALUES(90,3,15)");
            Sql("INSERT INTO MemberShipTypes VALUES(300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
