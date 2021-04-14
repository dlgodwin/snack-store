using System;
using System.Collections.Generic;
using SnackStore.Domain.Contexts;
using SnackStore.Domain.Model;

namespace SnackStore.Domain.Repositories
{
    public class CategoryRepository
    {
        private readonly ISnackStoreContext _context;

        public CategoryRepository(ISnackStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }
    }
}
