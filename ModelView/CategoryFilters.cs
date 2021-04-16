using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewShopApp.Models;
using NewShopApp.ModelView;

namespace NewShopApp.ModelView
{
    public class ShowItemsModelView
    {
        public List<Product> Products { get; set; }
        public string Category { get; set; }
        public List<string> AllCategories { get; set; }
    
    }
}
