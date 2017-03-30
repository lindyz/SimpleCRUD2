using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCRUD2.DAL
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Chore { get; set; }
        public string Day { get; set; }
    }
}