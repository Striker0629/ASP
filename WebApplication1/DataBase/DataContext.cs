﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.DataBase
{
    public class DataContext:DbContext
    {
        public DataContext():base("ServerDB")
        {
            
        }
    }
}