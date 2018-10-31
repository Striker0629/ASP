using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sells
    {
        public DateTime Deal { get; set; }
        public Int32 ProductID { get; set; }
        public Int32 Count { get; set; }
        public Single Profit { get; set; }
        public virtual Product Product {get;set;}
        
    }
}