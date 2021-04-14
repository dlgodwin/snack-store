using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SnackStore.Domain.Contexts;
using SnackStore.Domain.Model;

namespace SnackStore.Domain.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ISnackStoreContext _context;

        public CategoryRepository(ISnackStoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
