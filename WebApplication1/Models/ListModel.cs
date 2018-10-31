using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ListModel
    {
        private List<Product> products;
        public List<Product> Products => products; 

        public ListModel()
        {
            products = new List<Product>();
            products.AddRange(new Product[]
            {
                new Product{Name="HyperX Alloy FPS",Cash=2700,Id=0},
                new Product{Name="Razer Mamba Flux",Cash=4500,Id=1},
                new Product{Name="HyperX Pulsefire Core",Cash=1200,Id=2}
            });
        }
    }
}