using System;
using System.Collections.Generic;

#nullable disable

namespace _7.DemoDatabaseFirstAPI.DataAccess
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
