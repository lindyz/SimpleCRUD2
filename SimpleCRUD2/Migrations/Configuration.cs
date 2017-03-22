namespace SimpleCRUD2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleCRUD2.DAL.HousekeepingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleCRUD2.DAL.HousekeepingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.People.AddOrUpdate(
              p => p.FullName,
              new Person { Name = "" },
              new Person { Name = "Brice Lambson" },
              new Person { Name = "Rowan Miller" }
            );

        }
    }
}
