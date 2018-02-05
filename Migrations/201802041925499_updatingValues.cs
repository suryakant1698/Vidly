namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingValues : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set name='Pay As You Go' where ID='1'");
            Sql("update MembershipTypes set name='Monthly' where ID='2'");
        }
        
        public override void Down()
        {
        }
    }
}
