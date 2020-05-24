using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakkalaDigitalShopping.Data.Models;

namespace TakkalaDigitalShopping.Data.interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; set; }
        IEnumerable<Product> Statua { get; set; }
        Product GetProductByID(int Productid);
    }
}
