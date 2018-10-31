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
        public ActionResult List()
        {
            //ViewBag.Message = "THIS IS LIST";
            ViewBag.Products = new Models.ListModel().Products;
            return View();
        }
        public ActionResult Product(Int32 id)
        {
            return View(new Models.ListModel().Products[id]);
        }
    }
}