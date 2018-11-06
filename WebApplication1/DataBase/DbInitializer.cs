using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.DataBase
{
    public class DbInitializer:CreateDatabaseIfNotExists<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            //List<Models.Category> cat = new List<Models.Category>()
            //{
            //    new Models.Category(){Name="Weapon"},
            //    new Models.Category(){Name="Keyboard"},
            //    new Models.Category(){Name="Mices"}
            //};
            context.Category.Add(new Models.Category() { Name = "Weapon" });
            //context.Category.AddRange(cat);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}