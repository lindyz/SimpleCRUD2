using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SimpleCRUD2.DAL;
using SimpleCRUD2.Models;

namespace SimpleCRUD2.Controllers
{
    public class PersonController : Controller
    {
        private HousekeepingContext db = new HousekeepingContext();
        //private Task person;

        // GET: Person - 
        public ActionResult Index()
        {

            var model = new HousekeepingModel();
            model.Tasks = db.Tasks.ToList();
            
            //model.People = new SelectList(db.Persons.ToList(), "ChoreID", "Chore");
            //model.People = new SelectList(db.Persons.ToList(), "DayID", "Day");


            return View(model);
        }

        [HttpPost]
        public ActionResult Add(string FirstName, string Chore, string Day)
        {
            //string FirstName = Request.Form["FirstName"];
            //string Chore = Request.Form["Chore"];
            //string Day = Request.Form["Day"];

            ViewBag.FirstName = FirstName;
            ViewBag.Chore = Chore;
            ViewBag.Day = Day;


            return View();
        }

        // GET: Person/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task person = db.Tasks.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

      

        // POST: Person/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, Chore, Day")] Task person)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var myTask = db.Tasks.Find(id);
            if (myTask == null)
            {
                return HttpNotFound();
            }
            var model = new HousekeepingModel();

            model.TaskID = myTask.TaskID;
            model.Name = myTask.Name;
            model.Chore = myTask.Chore;
            model.Day = myTask.Day;

            return View(model);
        }

        // POST: Person/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskID, Name, Chore, Day")] Task person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task person = db.Tasks.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            
            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Task person = db.Tasks.Find(id);
            db.Tasks.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //[HttpPost]
        //public ActionResult Person(HousekeepingModel obj)
        //{

        //    ViewBag.Msg = "The Family Memeber Named " + obj.FirstName + " is assigned to " + obj.Chore + " on " + obj.Day;

        //    return View();

        //}
    }
}
