﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public double Price  { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }

        public int UserId  { get; set; }
        public int CategoryId  { get; set; }
        public  string Status { get; set; }
        public int Count { get; set; }
        public int BoughtCount { get; set; }
        public DateTime ExpiredDate { get; set; }

    }
}
