using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sells
    {
       [Key]
       public Int32 Id { get; set; }
        public DateTime Deal { get; set; }
        public Int32 ProductID { get; set; }
        public Int32 Count { get; set; }
        public Single Profit { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product {get;set;}
        
    }
}