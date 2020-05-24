using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakkalaDigitalShopping.Data.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandDesc { get; set; }
        public List<Product> Products { get; set; }
    }
}
