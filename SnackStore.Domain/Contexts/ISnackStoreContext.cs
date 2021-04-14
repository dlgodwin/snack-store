using Microsoft.EntityFrameworkCore;
using SnackStore.Domain.Model;

namespace SnackStore.Domain.Contexts
{
    public interface ISnackStoreContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
    }
}