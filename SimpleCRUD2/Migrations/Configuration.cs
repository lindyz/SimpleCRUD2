using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using SimpleCRUD2.DAL;

namespace SimpleCRUD2.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleCRUD2.DAL.HousekeepingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SimpleCRUD2.DAL.HousekeepingContext context)
        {

        }
    }
}

//    {
//        //  This method will be called after migrating to the latest version.

//        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
//        //  to avoid creating duplicate seed data. E.g.
//        //
//context.people.addorupdate(
//          p => p.firstname,
//          new person { name = "lindy" },
//          new person { name = "jason" },
//          new person { name = "baron" }
//        );

//context.chore.addorupdate(
//        c=> c.chore,
//        new chore {name = "vacuum" }
//        new chore {name = "sweep" }
//        new chore {name = "dust" }
//        new chore {name = "laundry" }
//        new chore {name = "mop" }
//        );

//context.day.addorupdate(
//        c=> c.day,
//        new day {name = "Monday" }
//        new day {name = "Tuesday" }
//        new day {name = "Wednesday" }
//        new day {name = "Thursday" }
//        new day {name = "Friday" }
//        new day {name = "Saturday" }
//        new day {name = "Sunday" }
//        );


//    }
//}

