using AspWebApi_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AspWebApi_Crud.Controllers
{
    public class CrudApiController : ApiController
    {
        MVC_Mentor_AssignmentEntities db=new MVC_Mentor_AssignmentEntities();
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetProducts()
        {
            List<Product> list=db.Products.ToList();
            return Ok(list);    
        }
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetProductById(int id)
        {
            var prod=db.Products.Where(model=>model.ProductID==id).FirstOrDefault();    
            return Ok(prod);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult ProdInsert(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();   
            return Ok();
        }
        [System.Web.Http.HttpPut]
        public IHttpActionResult ProdUpdate(Product p)
        {
            var prod= db.Products.Where(model=>model.ProductID==p.ProductID).FirstOrDefault();
            if(prod != null)
            {
                prod.ProductID = p.ProductID;
                prod.ProductName = p.ProductName;
                prod.ProductPrice = p.ProductPrice;
                prod.Category_id = p.Category_id;
                prod.Unit_ID=p.Unit_ID;
                db.SaveChanges();

            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
        [System.Web.Http.HttpDelete]
        public IHttpActionResult ProdDelete(int id)
        {
            var prod = db.Products.Where(model => model.ProductID == id).FirstOrDefault();
            db.Entry(prod).State=System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
