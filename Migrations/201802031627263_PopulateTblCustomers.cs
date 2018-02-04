namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTblCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("insert into customers(Name,IsSubscribedToNewsLetter,MembershipTypeID) values('John Smith',0,1)");
            Sql("insert into customers(Name,IsSubscribedToNewsLetter,MembershipTypeID) values('Mary Wiliams',1,2)");
        }
        
        public override void Down()
        {
        }
    }
}
