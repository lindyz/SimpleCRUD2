using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCRUD2.Models
{
    public class Chore
    {
        public int ChoreID { get; set; }
        public int DayID { get; set; }
        public int? PersonID { get; set; }


        public virtual Day Day { get; set; }
        public virtual Person Person { get; set; }
    }
}