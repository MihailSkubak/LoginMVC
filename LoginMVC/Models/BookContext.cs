﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginMVC.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

    }
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Year = 1863 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Year = 1895 });
            base.Seed(db);
        }
    }
}