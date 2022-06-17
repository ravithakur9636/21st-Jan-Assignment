using AspWebApi_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace AspWebApi_Crud.Controllers
{
    public class CrudMvcController : Controller
    {
        // GET: CrudMvc
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<Product> prod_list = new List<Product>();
            client.BaseAddress = new Uri("https://localhost:44354/api/CrudApi");
            var response = client.GetAsync("CrudApi");
            response.Wait();

            var test=response.Result;
            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Product>>();
                display.Wait();
                prod_list= display.Result;
            }
            return View(prod_list);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product prod)
        {
            client.BaseAddress = new Uri("https://localhost:44354/api/CrudApi");
            var response = client.PostAsJsonAsync<Product>("CrudApi", prod);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create");
        }
        public ActionResult Add(Product s)
        {
            MVC_Mentor_AssignmentEntities db = new MVC_Mentor_AssignmentEntities();
            db.Products.Add(s);
            db.SaveChanges();
            db.Dispose();
            return Redirect("Index");
        }

        public ActionResult Details(int id)
        {
            Product p = null;
            client.BaseAddress = new Uri("https://localhost:44354/api/CrudApi");
            var response = client.GetAsync("CrudApi?id="+ id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();
                p = display.Result;
            }
            return View(p);
        }
        public ActionResult Edit(int id)
        {
            Product p = null;
            client.BaseAddress = new Uri("https://localhost:44354/api/CrudApi");
            var response = client.GetAsync("CrudApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();
                p = display.Result;
            }
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            client.BaseAddress = new Uri("https://localhost:44354/api/CrudApi");
            var response = client.PutAsJsonAsync<Product>("CrudApi", p);
            response.Wait();
            var test=response.Result;
            if(test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Edit");
        }

        public ActionResult Save(Product s)
        {
            MVC_Mentor_AssignmentEntities db= new MVC_Mentor_AssignmentEntities();
            Product p=db.Products.Where(x=>x.ProductID==s.ProductID).FirstOrDefault();  
            p.ProductName = s.ProductName;
            p.ProductPrice = s.ProductPrice;    
            p.Category_id=s.Category_id;
            p.Unit_ID = s.Unit_ID;
            db.SaveChanges();   
            db.Dispose();
            return Redirect("Index");
        }

        public ActionResult Delete(int id)
        {
            Product p = null;
            client.BaseAddress = new Uri("https://localhost:44354/api/CrudApi");
            var response = client.GetAsync("CrudApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();
                p = display.Result;
            }
            return View(p);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("https://localhost:44354/api/CrudApi");
            var response = client.DeleteAsync("CrudApi/"+ id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Delete");
            
        }

    }
}