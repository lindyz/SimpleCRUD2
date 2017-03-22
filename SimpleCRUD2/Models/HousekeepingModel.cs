using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SimpleCRUD2.Models
{


    public class HousekeepingModel
    {
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Name is Required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Chore Type is Required.")]
        public string Chore { get; set; }

        [Required(ErrorMessage = "Room is Required.")]
        public string Room { get; set; }

        public string Day { get; set; }

    }

    class HousekeepingContext : DbContext
    {
        public DbSet<HousekeepingModel> Person { get; set; }
    }

}