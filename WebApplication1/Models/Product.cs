using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public Int32 Id { get; set;}
        public String Name { get; set; }
        public Single Cash { get; set; }

        public virtual Category Category { get; set; }
    }
}