using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM_2
{
    internal class Product
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public int CategoryIDProduct { get; set; }
        public double Price { get; set; }
        public int ProductCount { get; set; }
    }
}
