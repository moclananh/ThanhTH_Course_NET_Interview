using System;
using System.Collections.Generic;

#nullable disable

namespace _3.ProductManagement_MVC_DatabaseFirst.DataAccess
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
