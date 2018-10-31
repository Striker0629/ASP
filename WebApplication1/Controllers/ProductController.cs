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
            ViewBag.Message = "THIS IS LIST";
            ViewData.Model = new Models.ListModel();
            return View();
        }
    }
}