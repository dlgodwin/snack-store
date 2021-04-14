using System;
namespace SnackStore.Shared.DTO
{
    public class CategorizedProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
    }
}
