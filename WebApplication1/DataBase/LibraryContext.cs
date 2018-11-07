using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.DataBase
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("ServerDB")
        {
            Database.SetInitializer<LibraryContext>
                (new CreateDatabaseIfNotExists<LibraryContext>());
        }
        public DbSet<Models.Product>Products {get;set;}
        public DbSet<Models.Category>Category { get; set; }
        public DbSet<Models.Sells> Sells { get; set; }
    }
}