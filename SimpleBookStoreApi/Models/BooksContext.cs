using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleBookStoreApi.Models
{
    public class BooksContext: DbContext
    {
        public BooksContext() : base("DefaultConnection") { }

        public DbSet<Book> Books { get; set; }
    }
}