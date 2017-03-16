//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.ComponentModel.DataAnnotations;
//using System.Data.Entity;

//namespace SimpleCRUD2.Models
//{
   

//    public class StudentModel
//    {
//        public int StudentID { get; set; }
//        [Required(ErrorMessage ="Name is Required.")]
//        public string Name { get; set; }

//        [Required(ErrorMessage = "Chore Type is Required.")]
//        public string Chore { get; set; }

//        [Required(ErrorMessage = "Room is Required.")]
//        public string Room { get; set; }

//        public string Day { get; set; }

//    }

//    class StudentContext : DbContext
//    {
//        public DbSet<StudentModel> Students { get; set; }
//    }

//}