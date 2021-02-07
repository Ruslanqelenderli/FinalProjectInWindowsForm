﻿using RStore.DataContext;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RStore.DAL
{
    public class CrudDb
    {
        public void AddProduct(Product product,Logs log)
        {
            using(RStoreDataContext context=new RStoreDataContext())
            {
                context.Products.Add(product);
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }

    }
}
