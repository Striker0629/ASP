using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DataBase;
namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        static DataContext Db = new DataContext();
        private List<Models.Category> Categories { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        public CategoryController()
        {
            this.Categories = Db.Categories.ToList();
        }
    }
}