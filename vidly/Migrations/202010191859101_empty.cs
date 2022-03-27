namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empty : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes VALUES(0,0,0,'trial')");
            Sql("INSERT INTO MemberShipTypes VALUES(30,1,10,'Monthly')");
            Sql("INSERT INTO MemberShipTypes VALUES(90,3,15,'Quarterly')");
            Sql("INSERT INTO MemberShipTypes VALUES(300,12,20,'Yearly')");
        }
        
        public override void Down()
        {
        }
    }
}
