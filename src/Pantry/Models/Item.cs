using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Pantry.Controllers;

namespace Pantry.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePach { get; set; }
        public Vendor Vendor { get; set; }
        public decimal Price { get; set; }
        public int Score { get; set; }
        public List<Category> Categories { get; set; }
    }
}
