using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MVCMusicStore_11.DbContext;
using MVCMusicStore_11.Models;

namespace MVCMusicStore_11.Controllers
{
    public class ProductController : ApiController
    {
        private DataContext db = new DataContext();

        public IEnumerable<Product> GetProducts()
        {
            return db.Products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (ModelState.IsValid && id == product.ID)
            {
                db.Entry(product).State = EntityState.Modified;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            return BadRequest(ModelState);

        }

        public IHttpActionResult PostProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                var uri = new Uri(
                    Url.Link(
                        "DefaultApi",
                        new { id = product.ID }));
                return Created(uri, product);
            }
            return BadRequest(ModelState);
        }

        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null) return NotFound();
            db.Products.Remove(product);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {

                return NotFound();
            }
            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}