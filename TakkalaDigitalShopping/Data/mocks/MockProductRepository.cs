using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakkalaDigitalShopping.Data.interfaces;
using TakkalaDigitalShopping.Data.Models;

namespace TakkalaDigitalShopping.Data.mocks
{
    public class MockProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<Product> Statua { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Product GetProductByID(int Productid)
        {
            throw new NotImplementedException();
        }
    }
}
