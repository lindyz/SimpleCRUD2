﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCRUD2.Models
{
    public class Day
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DayID { get; set; }
        //public string Title { get; set; }
        //public int Credits { get; set; }

        public virtual ICollection<Chore> Chores { get; set; }
    }
}