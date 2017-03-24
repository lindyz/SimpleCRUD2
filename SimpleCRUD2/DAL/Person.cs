using System;
using System.Collections.Generic;

namespace SimpleCRUD2.DAL
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }

        //navigation property to link chores to the person
        public virtual ICollection<Chore> Chores { get; set; }
    }
}