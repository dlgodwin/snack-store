using System.Collections.Generic;
using System.Threading.Tasks;
using SnackStore.Domain.Model;

namespace SnackStore.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}