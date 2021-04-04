using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using NewShopApp.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace NewShopApp.Controllers
{

  //  [Authorize]
    public class ItemController : Controller
    {
        private readonly ApplicationContext applicationContext;
        public ItemController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> AddToCart(List<Product> products)
        {
            Cart cart = new Cart();
            if(products.Count==1)
            {
                cart.Products.Add(products[0]);
                cart.TotalPrice = products[0].Price;
                 JsonSerializer.Serialize(cart);
            }
            return RedirectToAction("All");
        }
        public async Task<IActionResult> All()
        {
            var q = await applicationContext.Products.ToListAsync();
            return View(q);
        }
    }
}
