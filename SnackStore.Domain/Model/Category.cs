using System;
using System.Collections.Generic;

#nullable disable

namespace SnackStore.Domain.Model
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategroyName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
