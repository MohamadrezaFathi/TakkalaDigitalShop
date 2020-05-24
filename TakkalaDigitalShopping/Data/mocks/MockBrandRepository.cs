using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakkalaDigitalShopping.Data.interfaces;
using TakkalaDigitalShopping.Data.Models;

namespace TakkalaDigitalShopping.Data.mocks
{
    public class MockBrandRepository : IBrandRepository
    {
        public IEnumerable<Brand> Brands => throw new NotImplementedException();
    }
}
