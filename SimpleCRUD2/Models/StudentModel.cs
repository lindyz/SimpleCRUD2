using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleCRUD2.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage ="Student Name is Required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Class Type is Required.")]
        public string Class { get; set; }
    }
}