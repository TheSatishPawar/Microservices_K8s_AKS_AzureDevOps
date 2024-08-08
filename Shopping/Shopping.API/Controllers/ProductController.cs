﻿using Microsoft.AspNetCore.Mvc;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController 
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductContext.Products;
            //var rng= new Random();

            //return Enumerable.Range(1, 5).Select(x => new Product
            //{
            //    Name = "ssp"
            //}).ToArray();
        }
    }
}
