using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GalaxyStoreAPI.DAL;
using GalaxyStoreAPI.Models;

namespace GalaxyStoreAPI.Controllers
{
    public class ProductController : ApiController
    {
        private GalaxyStoreDbContext db = new GalaxyStoreDbContext();

        // GET: api/Products
        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        public Product GetProduct(int? id)
        {
            Product product = db.Products.Find(id);
            return product;
        }

        public HttpResponseMessage PostProduct (Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                HttpResponseMessage responseMessage = Request.CreateResponse(HttpStatusCode.Created);
                return responseMessage;
            }
            else
            {
                HttpResponseMessage responseMessage = Request.CreateResponse(HttpStatusCode.BadRequest);
                return responseMessage;

            }
        }

        public HttpResponseMessage PutProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                HttpResponseMessage responseMessage = Request.CreateResponse(HttpStatusCode.OK);
                return responseMessage;
            }
            else
            {
                HttpResponseMessage responseMessage = Request.CreateResponse(HttpStatusCode.BadRequest);
                return responseMessage;

            }
        }

        public HttpResponseMessage DeleteProduct(int? id)
        {
            if (id == null)
            {
                HttpResponseMessage responseMessage = Request.CreateResponse(HttpStatusCode.BadRequest);
                return responseMessage;
                
            }
            else
            {
                Product product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                HttpResponseMessage responseMessage = Request.CreateResponse(HttpStatusCode.OK);
                return responseMessage;

            }
        }







    }
}
