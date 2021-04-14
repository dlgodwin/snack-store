using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnackStore.Domain.Model;
using SnackStore.Services;
using SnackStore.Shared.DTO;

namespace SnackStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        //{
        //    var products = await _productService.GetAllProducts();
        //    return Ok(products);
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategorizedProductDto>>> GetCategorizedProducts()
        {
            var products = await _productService.GetCategorizedProducts();
            return Ok(products);
        }
    }
}
