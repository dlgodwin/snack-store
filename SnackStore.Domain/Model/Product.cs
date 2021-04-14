﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SnackStore.Domain.Model
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
