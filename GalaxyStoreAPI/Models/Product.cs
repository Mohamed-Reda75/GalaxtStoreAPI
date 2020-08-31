using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GalaxyStoreAPI.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public float UnitPrice { get; set; }

        public short CategoryID { get; set; }

        public Category Category { get; set; }
    }
}