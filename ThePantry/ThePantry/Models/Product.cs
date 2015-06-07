using System.Collections.Generic;

namespace ThePantry.Api.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePach { get; set; }

        public Vendor Vendor { get; set; }

        public double Price { get; set; }

        public int Score { get; set; }

        public List<Category> Categories { get; set; }
    }
}