using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnackStore.Domain.Model;
using SnackStore.Domain.Repositories;
using SnackStore.Shared.DTO;

namespace SnackStore.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }

        public async Task<IEnumerable<CategorizedProductDto>> GetCategorizedProducts()
        {
            var products = await _productRepository.GetAllProducts();
            var categories = await _categoryRepository.GetAllCategories();

            var categorizedProducts = from product in products.ToList()
                                      join category in categories.ToList()
                                        on product.CategoryId equals category.CategoryId
                                      select new CategorizedProductDto
                                      {
                                          ProductId = product.ProductId,
                                          ProductName = product.ProductName,
                                          Category = category.CategroyName
                                      };

            return categorizedProducts;
        }
    }
}
