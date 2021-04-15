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
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace NewShopApp.Controllers
{

    //  [Authorize]
    public class ItemController : Controller
    {
        private readonly ApplicationContext applicationContext;
        private readonly OrderDbContext orderDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        public ItemController(ApplicationContext applicationContext, UserManager<ApplicationUser> userManager,
            OrderDbContext orderDbContext)
        {
            this.applicationContext = applicationContext;
            _userManager = userManager;
            this.orderDbContext = orderDbContext;
        }
       [HttpGet]
        public IActionResult  OrderCreate()
        {
        var cart=JsonConvert.DeserializeObject<Cart>(    HttpContext.Session.GetString("Cart"));
            string items = JsonConvert.SerializeObject(cart.Products);
          //  string price = JsonConvert.SerializeObject(cart.TotalPrice);
            if(User.Identity.IsAuthenticated)
            {
                //
            }
            OrderCreateViewModel orderCreateViewModel = new OrderCreateViewModel();
            orderCreateViewModel.Items = items;
            orderCreateViewModel.TotalPrice = cart.TotalPrice;
            return View(orderCreateViewModel);
          

        }


        //public async Task<IActionResult> OrderConfirm(long id)
        //{
        //    var order = await orderDbContext.Orders.FirstOrDefaultAsync(i => i.Id == id);
        //    if(order!=null)
        //    {
        //        order.Status = "Confirmed";
        //        orderDbContext.Orders.Update(order);
        //        await orderDbContext.SaveChangesAsync();
        //        return Ok(); 
        //    }
        //    return NotFoundError("No order with such id");
        //}


        //public async Task<IActionResult> RemoveOrder(long id)
        //{
        //    var order = await orderDbContext.Orders.FirstOrDefaultAsync(i => i.Id == id);
        //    if (order != null)
        //    {

        //        orderDbContext.Orders.Remove(order);
        //        await orderDbContext.SaveChangesAsync();
        //        return Ok();
        //    }
        //    return NotFoundError("No order with such id");
        //}
        //public async Task<IActionResult> OrderDone(long id)
        //{
        //    var order = await orderDbContext.Orders.FirstOrDefaultAsync(i => i.Id == id);
        //    if ((order != null) && order.Status!="Done" )
        //    {
        //        order.Status = "Done";
        //        orderDbContext.Orders.Update(order);
        //        await orderDbContext.SaveChangesAsync();
        //        return Ok();
        //    }
        //    return NotFoundError("No order with such id");

        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrderCreate(OrderCreateViewModel orderCreateViewModel)
        {
            
            if(orderCreateViewModel!=null)
            {
                if (ModelState.IsValid)
                {
                    Order order = new Order()
                    {
                        TotalPrice = orderCreateViewModel.TotalPrice,
                        Address = orderCreateViewModel.Address,
                        City = orderCreateViewModel.City,
                        Country = orderCreateViewModel.Country,
                        Phone = orderCreateViewModel.Phone,
                        Email = orderCreateViewModel.Email,
                        Name = orderCreateViewModel.Name,
                        OrderItems = orderCreateViewModel.Items,
                        SecondName = orderCreateViewModel.SecondName,
                        Status="Created",
                        CreateDateTime=DateTime.Now

                    };
                  
                    await orderDbContext.AddAsync(order);
                    await orderDbContext.SaveChangesAsync();
                    if(User.Identity.IsAuthenticated)
                    {
                     var name=   User.FindFirst(ClaimTypes.Name)?.Value;
                        var user = await _userManager.FindByNameAsync(name);
                        user.CartList = String.Empty;
                        await _userManager.UpdateAsync(user);
                    }
                    HttpContext.Session.SetString("Cart", String.Empty);
                }
              
            }

           
            return RedirectToAction("Index", "Home");
           
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
                if(User.Identity.IsAuthenticated)
                {
                  var r=  User.FindFirst(ClaimTypes.Name)?.Value;
                    var user = await _userManager.FindByNameAsync(r);
                    user.CartList = cartValue;
                  await  _userManager.UpdateAsync(user);
                    
                }    
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
        [Route("CurrentCart")]
        [Route("{controller}/CurrentCart")]
        public async Task<IActionResult> CurrentCart()
        {
            string json_cart = HttpContext.Session.GetString("Cart");
            Cart cart = new Cart();
            if (json_cart != null)
            {
                 cart = JsonConvert.DeserializeObject<Cart>(json_cart);
            }
            if(User.Identity.IsAuthenticated)
            {
                var r = User.FindFirst(ClaimTypes.Name)?.Value;
                var user = await _userManager.FindByNameAsync(r);
             cart=   JsonConvert.DeserializeObject<Cart>(user.CartList);
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
              await  HttpContext.Session.CommitAsync();

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
                            if(User.Identity.IsAuthenticated)
                        {
                            var name = User.FindFirst(ClaimTypes.Name)?.Value;
                            var curUser =await _userManager.FindByNameAsync(name);
                            curUser.CartList = result;
                            await _userManager.UpdateAsync(curUser);
                        }
                        
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

                    return RedirectToAction("Error");
                }
            }
            //return View();
           
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
