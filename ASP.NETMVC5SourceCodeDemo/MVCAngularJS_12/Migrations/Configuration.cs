using MVCAngularJS_12.Models;

namespace MVCAngularJS_12.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContext.MovieDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCAngularJS_12.DbContext.MovieDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Movies.AddOrUpdate(m => m.Title,
                new Movie { Title = "Star Wars", ReleaseYear = 1977, Runtime = 121 },
                new Movie { Title = "Inception", ReleaseYear = 2010, Runtime = 148 },
                new Movie { Title = "Toy Story", ReleaseYear = 1995, Runtime = 81 });
            context.SaveChanges();
        }
    }
}
