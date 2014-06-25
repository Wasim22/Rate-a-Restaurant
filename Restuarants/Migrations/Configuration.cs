namespace Restuarants.Migrations
{
    using Restuarants.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Restuarants.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Restuarants.Models.ApplicationDbContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            db.Restuarants.AddOrUpdate(
              r => r.Id,
              new Restuarant { Id = 1, Name = "Fist of the Dragon Inn", Cuisine = "Chinese", Rating = 4, Img = "http://chrismerriman.com/ACDImages/200804/20080421-DSC00503.jpg" },
              new Restuarant { Id = 2, Name = "Maharaja Inn", Cuisine = "Indian", Rating = 5, Img = "http://media-cdn.tripadvisor.com/media/photo-s/02/87/c8/11/filename-taj-01-jpg-thumbnail0.jpg" },
              new Restuarant { Id = 3, Name = "Double Chin Inn", Cuisine = "American", Rating = 4, Img = "http://www.projectsatoz.com/wp-content/gallery/american_restaurant_tahiti/american_restaurant_tahiti_03.jpg" }
            );
        }
    }
}
