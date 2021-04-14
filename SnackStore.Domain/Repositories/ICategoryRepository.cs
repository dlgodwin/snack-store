using System.Collections.Generic;
using System.Threading.Tasks;
using SnackStore.Domain.Model;

namespace SnackStore.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
    }
}