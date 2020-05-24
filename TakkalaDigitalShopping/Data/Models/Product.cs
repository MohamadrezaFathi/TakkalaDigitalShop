using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakkalaDigitalShopping.Data.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Decimal Price { get; set; }
        public string TotalDescription { get; set; }
        public string  ImageURL { get; set; }
        public string color { get; set; }
        public int inStock { get; set; }
        public string IntroductionDate { get; set; }
        public int status { get; set; }
        public int BrandID { get; set; }
        public int SubGroupID { get; set; }

        public virtual SubGroup SubGroup { get; set; }
        public virtual Brand Brand { get; set; }


    }
}
