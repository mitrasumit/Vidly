namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberinStock)VALUES('Shrek',3,'2001-10-09','2015-05-11',2)");
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberinStock)VALUES('Wall-E',3,'2001-10-10','2015-05-11',4)");
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberinStock)VALUES('Krish',1,'2001-10-11','2015-05-11',6)");
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberinStock)VALUES('Rambo',2,'2001-10-12','2015-05-11',10)");
            Sql("INSERT INTO Movies(Name,GenreId,ReleaseDate,DateAdded,NumberinStock)VALUES('Die Hard',5,'2001-10-13','2015-05-11',1)");
        }
        
        public override void Down()
        {
        }
    }
}
