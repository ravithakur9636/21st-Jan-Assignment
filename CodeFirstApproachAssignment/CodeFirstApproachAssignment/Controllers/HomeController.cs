using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproachAssignment.Models;

namespace CodeFirstApproachAssignment.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "City")
            {
                var data = db.Students.Where(model=>model.City.StartsWith(search)).ToList();
                return View(data);
            }
            else if (searchBy == "Branch")
            {
                var data = db.Students.Where(model => model.Branch.StartsWith(search)).ToList();
                return View(data);
            }
            else if (searchBy == "Percentage")
            {
                var data = db.Students.Where(model => model.Percentage == (int) Session["StudentContext"]).ToList();
                return View(data);
            }
            else if (searchBy == "StudentId")
            {
                var data = db.Students.Where(model => model.StudentId == (int)Session["StudentContext"]).ToList();
                return View(data);
            }
            else
            {
                var data=db.Students.ToList();
                return View(data);
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    //ViewBag.InsertMessage = "<script>alert('Data Inserted !!')</script>";
                    TempData["InsertMessage"] = "Data Inserted !!";
                    //ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data Not Inserted !!')</script>";
                }

            }

            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model => model.StudentId == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["UpdateMessage"] = "<script>alert('data updated')</script)";
                    return RedirectToAction("Index");
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.UpdateMessage = "<script>alert('data not updated')</script)";
                }
            }

            return View();
        }
        public ActionResult Delete(int id)
        {
            if(id > 0)
            {
                var StudentIdRaw=db.Students.Where(model => model.StudentId == id).FirstOrDefault();
                if(StudentIdRaw!=null)
                {
                    db.Entry(StudentIdRaw).State = System.Data.Entity.EntityState.Deleted;
                    int a = db.SaveChanges();

                    if (a > 0)
                    {
                        TempData["DeleteMessage"] = "<script>alert('Data Deleted !!')</script>";

                    }
                    else
                    {
                        TempData["DeleteMessage"] = "<script>alert('Data Not Deleted !!')</script>";
                    }
                    
                }
            }
            return RedirectToAction("Index");

        }
        

    }
}