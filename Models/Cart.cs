using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShopApp.Models
{
    public class Cart
    {
        public long Id { get; set; }
        public List<Product> Products {get;set;}
        public decimal TotalPrice { get; set; }

    }
}
