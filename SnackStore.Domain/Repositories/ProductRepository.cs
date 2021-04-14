using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SnackStore.Domain.Contexts;
using SnackStore.Domain.Model;

namespace SnackStore.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISnackStoreContext _context;

        public ProductRepository(ISnackStoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
