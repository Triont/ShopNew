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
using NewShopApp.ModelView;
using Newtonsoft.Json;

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
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Show(long id)
        {
            var item=await applicationContext.Products.FirstOrDefaultAsync(i => i.Id==id);
            if(item!=null)
            {
                return View(item);
            }
            return RedirectToAction("NotFoundError", new { message=" Page not found" });
        }
        public ActionResult NotFoundError(string message)
        {
            ErModelView erModelView = new ErModelView();
            erModelView.Message = message;
            ViewBag.Message = message;
            return View(erModelView);
        }

        public async Task<IActionResult> AddToCart(long ProductId)
        {
            Cart cart = new Cart();
            if (HttpContext.Session.GetString("Cart")!=null)
            {
                cart  = JsonConvert.
                    DeserializeObject<Cart>(HttpContext.Session.GetString("Cart"));
            }
            var product = await applicationContext.
                Products.FirstOrDefaultAsync(i => i.Id == ProductId);
         
            if(product!=null)
            {
                if (cart != null)
                {
                    if (cart.Products != null)
                    {

                        cart.Products.Add(product);
                        cart.TotalPrice += product.Price;
                    }
                    else
                    {
                        cart.Products = new List<Product>();
                        cart.Products.Add(product);
                        cart.TotalPrice = product.Price;
                    }
                }
                //else
                //{
                   
                //    cart.Products.Add(product);
                //    cart.TotalPrice = product.Price;
                //}
                string cartValue = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("Cart", cartValue);
                await HttpContext.Session.CommitAsync();

                
            }


           
            //if(products.Count==1)
            //{
            //    cart.Products.Add(products[0]);
            //    cart.TotalPrice = products[0].Price;
            //     JsonSerializer.Serialize(cart);
            //}
            return RedirectToAction("All");
        }
        public IActionResult CurrentCart()
        {
            string json_cart = HttpContext.Session.GetString("Cart");
            Cart cart = new Cart();
            if (json_cart != null)
            {
                 cart = JsonConvert.DeserializeObject<Cart>(json_cart);
            }
            return View(cart);
        }
        public async Task<IActionResult> RemoveFromCart(long id)
        {
            string str = HttpContext.Session.GetString("Cart");
            var cart = JsonConvert.DeserializeObject<Cart>(str);
            var itemToRemove = await applicationContext.
                Products.FirstOrDefaultAsync(i => i.Id == id);
            if(cart!=null)
            {
                if(cart.Products!=null)
                {
                    if (itemToRemove != null)
                    {
                        var itemInList = cart.Products.Find(x => x.Id == itemToRemove.Id);
                            cart.TotalPrice -= itemInList.Price;
                            cart.Products.Remove(itemInList);
                            string result = JsonConvert.SerializeObject(cart);
                            HttpContext.Session.SetString("Cart", result);
                            await HttpContext.Session.CommitAsync();
                        
                    }
                }
            }
            return RedirectToAction("CurrentCart");
            
        }
        public async Task<IActionResult> All()
        {
            ShowItemsModelView showItemsModelView = new ShowItemsModelView();
            var q = await applicationContext.Products.ToListAsync();
            showItemsModelView.Products = q;
            
            var categories = q.Select(i => i.Category).Distinct().ToList();
            TempData["Categories"] = JsonConvert.SerializeObject(categories);
            if (TempData["SelectedCategory"] == null)
            {
                //var q = await applicationContext.Products.ToListAsync();
                //var categories = q.Select(i => i.Category).Distinct().ToList();
               // TempData["Categories"] = categories;
                return View(showItemsModelView);
            }
            else
            {
                try
                {
                    var zzz = TempData["SelectedCategory"].ToString();
                    var tmp = JsonConvert.DeserializeObject < List<Product>>(zzz);
                    showItemsModelView.Products = tmp;
                    return View(showItemsModelView);
                }
                catch(InvalidCastException e)
                {
                    
                }
            }
            return View();
           
        }

        public async Task<IActionResult> CategorySelect(string[]Categories)
        {
            var q = await applicationContext.Products.ToListAsync();
            List<Product> tmp = new List<Product>();
            foreach (var iq in Categories)
            {
                var lst = q.Select((i => i)).Where(k => k.Category == iq).ToList();
                tmp.AddRange(lst);
               
            }
            TempData["SelectedCategory"] = JsonConvert.SerializeObject(tmp);
            return RedirectToAction("All");

        }
    }
}
