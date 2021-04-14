using System;
using System.Collections;
using System.Collections.Generic;
using SnackStore.Domain.Contexts;
using SnackStore.Domain.Model;

namespace SnackStore.Domain.Repositories
{
    public class ProductRepository
    {
        private readonly ISnackStoreContext _context;

        public ProductRepository(ISnackStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }
    }
}
