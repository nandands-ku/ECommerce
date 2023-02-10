using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Ecommerce.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
            var user = HttpContext.User.GetUserEmail();

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
