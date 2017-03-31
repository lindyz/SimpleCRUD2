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

