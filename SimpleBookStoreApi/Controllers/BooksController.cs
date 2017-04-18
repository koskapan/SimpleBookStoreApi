using SimpleBookStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SimpleBookStoreApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class BooksController : ApiController
    {
        // GET api/values
        public IEnumerable<Book> Get()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Books.ToList();
            }
        }
        
        // GET api/values/5
        public Book Get(Guid id)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Books.FirstOrDefault(b => b.ID == id) ;
            }
        }
        
        // POST api/values
        public void Post([FromBody]Book value)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Books.Add(value);
                db.SaveChanges();
            }
        }
        
        // PUT api/values/5
        public void Put(Guid id, [FromBody]Book value)
        {
            using (var db = new ApplicationDbContext())
            {
                if (id == value.ID)
                {
                    db.Entry(value).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        
        // DELETE api/values/5
        public void Delete(Guid id)
        {
            using (var db = new ApplicationDbContext())
            {
                var bookForDelete = db.Books.FirstOrDefault(b => b.ID == id);
                if (bookForDelete != null)
                {
                    db.Books.Remove(bookForDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}
