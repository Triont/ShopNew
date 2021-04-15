using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShopApp.Models;

namespace NewShopApp.ModelView
{
    public class AdminGetAllOrdresModelView
    {
        public List<Order> Orders { get; set; }
        public List<string> Statuses { get; set; }
        public List<string> StatusesChecked { get; set; }
    }
}
