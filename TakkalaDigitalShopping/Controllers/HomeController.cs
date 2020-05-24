using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakkalaDigitalShopping.Data.interfaces;

namespace TakkalaDigitalShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IGroupRepository _groupRepository;
        private readonly ISubGroupRepository _subGroupRepository;
        private readonly IBrandRepository _brandRepository;
        public HomeController(IProductRepository productRepository,IGroupRepository groupRepository,ISubGroupRepository subGroupRepository,IBrandRepository brandRepository)
        {
            _productRepository = productRepository;
            _groupRepository = groupRepository;
            _subGroupRepository = subGroupRepository;
            _brandRepository = brandRepository;

        }

        public ViewResult List()
        {
            var products = _productRepository.Products;
            return View(products);
        }

    }
}
