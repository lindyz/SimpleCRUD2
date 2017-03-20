using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SimpleCRUD2.Models;

namespace SimpleCRUD2.DAL
{
    public class HousekeepingInitializer
 : System.Data.Entity.DropCreateDatabaseIfModelChanges<HousekeepingContext>
    {
        protected override void Seed(HousekeepingContext context)
        {
            var persons = new List<Person>
            {
            new Person{FirstName="Lindy"},
            new Person{FirstName="Jason"},
            new Person{FirstName="Baron"},
            };
            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
            
            var days = new List<Day>
            {
            new Day{DayID="Monday"},
            new Day{DayID="Tuesday"},
            new Day{DayID="Wednesday"},
            new Day{DayID="Thursday"},
            new Day{DayID="Friday"},
            new Day{DayID="Saturday"},
            new Day{DayID="Sunday"},
            };
            days.ForEach(s => context.Days.Add(s));
            context.SaveChanges();

            var chores = new List<Chore>
            {
            new Chore{PersonID=1,DayID="Monday", chores="vacuum"},
            new Chore{PersonID=2,DayID="Tuesday", chores="dust"},
            new Chore{PersonID=2,DayID="Wednesday", chores="do dishes"},
            new Chore{PersonID=3,DayID="Thursday", chores="mop"},
            new Chore{PersonID=3,DayID="Friday", chores="sweep"},
            };
            chores.ForEach(s => context.Chores.Add(s));
            context.SaveChanges();
        }
    }
}