using System.Collections.Generic;
using System.Threading.Tasks;
using SnackStore.Domain.Model;
using SnackStore.Shared.DTO;

namespace SnackStore.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<IEnumerable<CategorizedProductDto>> GetCategorizedProducts();
    }
}