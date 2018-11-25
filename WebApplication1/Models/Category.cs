using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Category
    {
        public ICollection<Product> Products { get; set; }
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String FileName { get; set; }
    }
}