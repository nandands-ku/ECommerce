using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseApiController
    {
        private readonly IGenericRepository<Products> _productRepository;
        public ProductsController(IGenericRepository<Products> productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet(nameof(GetProducts))]
        public async Task<ActionResult<List<Products>>> GetProducts()
        {

            var products = await _productRepository.GetAllAsync();
            return Ok(products);
        }

        [HttpPost]
        public ActionResult SaveProducts(Products product)
        {

            _productRepository.Save(product);
            return Ok();
        }
    }
}
