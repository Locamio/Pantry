using System.Collections.Generic;

namespace ThePantry.Api.Models
{
    public class Vendor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}