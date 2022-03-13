using AspAssignment.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspAssignment.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbObj = new db_testEntities();  
        public ActionResult Student(tbl_Student obj)
        {
           
            return View(obj);
            
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student obj = new tbl_Student();
            if (ModelState.IsValid)
            {
                obj.HNo = model.HNo;    
                obj.Name = model.Name;
                obj.Family_Name = model.Family_Name;
                obj.Address = model.Address;
                obj.City = model.City;
                obj.Zip_code = model.Zip_code;
                obj.Phone = model.Phone;
                obj.Email = model.Email;
                if (model.HNo == 0)
                {
                    dbObj.tbl_Student.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State=System.Data.Entity.EntityState.Modified;
                    dbObj.SaveChanges();
                }
            }
            ModelState.Clear();
               
            return View("Student");
        }

        public ActionResult StudentList()
        {
            var res=dbObj.tbl_Student.ToList(); 
            return View(res);
        }

        public ActionResult Delete(int hno)
        {
            var res = dbObj.tbl_Student.Where(x => x.HNo == hno).First();
            dbObj.tbl_Student.Remove(res);
            dbObj.SaveChanges();
            var list=dbObj.tbl_Student.ToList();
            return View("StudentList",list);
        }
    }
}