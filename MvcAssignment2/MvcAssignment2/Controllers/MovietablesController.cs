using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MvcAssignment2.Models;

namespace MvcAssignment2.Controllers
{
    public class MovietablesController : Controller
    {
        private MovieEntities db = new MovieEntities();

        // GET: Movietables
        public ActionResult Index()
        {
            return View(db.Movietables.ToList());
        }
        [HttpGet]
        public async Task<ActionResult> Index(string MovieSearch)
        {
            ViewData["mid"]=MovieSearch;
            var moviequery=from x in db.Movietables select x;
            if(!string.IsNullOrEmpty(MovieSearch))
            {
                moviequery=moviequery.Where(x=>x.dateofrelease.Contains(MovieSearch)); 
            }
            return View(await moviequery.AsNoTracking().ToListAsync());    
        }

        // GET: Movietables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movietable movietable = db.Movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }

        // GET: Movietables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movietables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "mid,moviename,dateofrelease")] Movietable movietable)
        {
            if (ModelState.IsValid)
            {
                db.Movietables.Add(movietable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movietable);
        }

        // GET: Movietables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movietable movietable = db.Movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }

        // POST: Movietables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mid,moviename,dateofrelease")] Movietable movietable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movietable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movietable);
        }

        // GET: Movietables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movietable movietable = db.Movietables.Find(id);
            if (movietable == null)
            {
                return HttpNotFound();
            }
            return View(movietable);
        }

        // POST: Movietables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movietable movietable = db.Movietables.Find(id);
            db.Movietables.Remove(movietable);
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
    }
}
