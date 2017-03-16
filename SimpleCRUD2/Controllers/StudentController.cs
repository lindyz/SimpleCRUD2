using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCRUD2.Models;

namespace SimpleCRUD2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {

            return View();


        }
        //this action will happen when you execute - the above will be blank
        [HttpPost]
        public ActionResult Student(StudentModel obj)
        {

            ViewBag.Msg="The Family Memeber Named "+obj.Name+" is assigned to "+obj.Chore+" the "+obj.Room+" on "+obj.Day;

            return View();

        }
    }
}