using SimpleCRUD2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SimpleCRUD2.DAL
{
    public class HousekeepingContext : DbContext
    {
        //the name of the connection string passed to the constructor
        public HousekeepingContext() : base("HousekeepingContext")
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<Day> Days { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}