using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SnackStore.Domain.Model;
using SnackStore.Domain.Repositories;

namespace SnackStore.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }
    }
}
