namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateTableGenre : DbMigration
    {
        public override void Up()

        {
           // insert into customers(Name, IsSubscribedToNewsLetter, MembershipTypeID) values('John Smith', 0, 1)
            Sql("insert into Genres(Name) values('Comedy') ");
            Sql("insert into Genres(Name) values('Suspense') ");
            Sql("insert into Genres(Name) values('Thriller') ");
            Sql("insert into Genres(Name) values('Sci-Fi') ");
            Sql("insert into Genres(Name) values('Drama') ");


        }

        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreID", c => c.Byte(nullable: false));
        }
    }
}
