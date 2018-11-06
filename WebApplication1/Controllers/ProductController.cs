using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        static DataBase.LibraryContext context = new DataBase.LibraryContext();
        static Models.ListModel Models;
        static ProductController()
        {
            Models = new WebApplication1.Models.ListModel();
        }
        public ActionResult List()
        {
            //ViewBag.Message = "THIS IS LIST";
            ViewBag.Products = new Models.ListModel().Products;
            return View();
        }
        public ActionResult Product(Int32 id)
        {
            Models.Product find;
            try
            {
                
                find = Models.Products.Find(p => p.Id == id);
               
                return View(new Models.ListModel().Products.Find(p => p.Id == id));
            }
            catch (ArgumentNullException)
            {
                return View();
            }
            
            //return View(new Models.ListModel().Products.Find( p => p.Id==id));
        }
    }
}