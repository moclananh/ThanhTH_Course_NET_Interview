using System;
using System.Collections.Generic;

#nullable disable

namespace _6.DemoDockerAPI.DataAccess
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CateId { get; set; }
        public int? SellId { get; set; }
    }
}
