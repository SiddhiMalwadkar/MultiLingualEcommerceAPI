using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MultiLingualEcommerceAPI.Models;
using System.Collections.Generic;

namespace MultiLingualEcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IStringLocalizer<ProductsController> _localizer;

        public ProductsController(IStringLocalizer<ProductsController> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            // In a real app, IDs would map to localization keys in Resource files
            var products = new List<Product>
            {
                new Product { 
                    Id = 1, 
                    SKU = "LAP-001", 
                    Price = 999.99m,
                    Name = _localizer["LaptopName"], 
                    Description = _localizer["LaptopDesc"] 
                },
                new Product { 
                    Id = 2, 
                    SKU = "PHN-002", 
                    Price = 499.99m,
                    Name = _localizer["PhoneName"], 
                    Description = _localizer["PhoneDesc"] 
                }
            };

            return Ok(products);
        }
    }
}
