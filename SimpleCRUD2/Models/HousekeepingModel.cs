using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using SimpleCRUD2.DAL;
using System.Web.Mvc;

namespace SimpleCRUD2.Models
{


    public class HousekeepingModel
    {
        public int TaskID { get; set; }

        [Required(ErrorMessage = "Name is Required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Chore Type is Required.")]
        public string Chore { get; set; }

        //[Required(ErrorMessage = "Room is Required.")] might add this back in on a later version so I'm leaving it here to remind me
        //public string Room { get; set; }

        public string Day { get; set; }

        public List<SimpleCRUD2.DAL.Task> Tasks { get; set; }
    }

  

}