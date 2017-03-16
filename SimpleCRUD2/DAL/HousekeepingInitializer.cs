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
            new Person{FirstMidName="Lindy"},
            new Person{FirstMidName="Jason"},
            new Person{FirstMidName="Baron"},
            };
            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
            
            var days = new List<Day>
            {
            new Day{},
            };
            days.ForEach(s => context.Days.Add(s));
            context.SaveChanges();

            var chores = new List<Chore>
            {
            new Chore{PersonID=1,DayID=1050},
            new Chore{PersonID=1,DayID=1050},
            new Chore{PersonID=2,DayID=1050},
            new Chore{PersonID=2,DayID=1050},
            new Chore{PersonID=3,DayID=1050},
            new Chore{PersonID=3,DayID=1050},
            };
            chores.ForEach(s => context.Chores.Add(s));
            context.SaveChanges();
        }
    }
}