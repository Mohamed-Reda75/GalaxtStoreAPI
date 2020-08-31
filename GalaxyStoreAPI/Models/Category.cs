using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GalaxyStoreAPI.Models
{
    public class Category
    {
        public short CategoryID { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}