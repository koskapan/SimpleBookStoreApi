using SimpleBookStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleBookStoreApi.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/values
        public IEnumerable<Book> Get()
        {
            using (var db = new BooksContext())
            {
                return db.Books.ToList();
            }
        }
        
        // GET api/values/5
        public Book Get(int id)
        {
            using (var db = new BooksContext())
            {
                return db.Books.FirstOrDefault(b => b.ID == id) ;
            }
        }
        
        // POST api/values
        public void Post([FromBody]Book value)
        {
            using (var db = new BooksContext())
            {
                db.Books.Add(value);
                db.SaveChanges();
            }
        }
        
        // PUT api/values/5
        public void Put(int id, [FromBody]Book value)
        {
            using (var db = new BooksContext())
            {
                if (id == value.ID)
                {
                    db.Entry(value).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        
        // DELETE api/values/5
        public void Delete(int id)
        {
            using (var db = new BooksContext())
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
