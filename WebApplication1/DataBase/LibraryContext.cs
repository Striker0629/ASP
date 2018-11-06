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

        }
        public List<Models.Product>Products {get;set;}
        public List<Models.Category>Category { get; set; }
        public List<Models.Sells> Sells { get; set; }
    }
}