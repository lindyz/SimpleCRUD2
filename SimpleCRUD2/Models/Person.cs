using System;
using System.Collections.Generic;

namespace SimpleCRUD2.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstMidName { get; set; }

        //navigation property to link chores to the person
        public virtual ICollection<Chore> Chores { get; set; }
    }
}