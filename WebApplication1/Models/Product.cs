using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public Int32 Id { get; set;}
        public String Name { get; set; }
        public Single Cash { get; set; }
        public Int32 CategoryID { get; set; }
        [ForeignKey("Category")]
        public virtual Category Category { get; set; }
    }
}