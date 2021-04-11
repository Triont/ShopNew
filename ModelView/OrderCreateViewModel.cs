using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShopApp.ModelView
{
    public class OrderCreateViewModel
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
