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
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly OrderDbContext orderDbContext;
        public AdminController(OrderDbContext orderDbContext)
        {
            this.orderDbContext = orderDbContext;
        }
        // GET: AdminController
        [Route("[controller]/Index")]
        [Route("[controller]")]
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetUnconfirmedOrders()
        {
            var all = await orderDbContext.Orders.Where(i => i.Status == "Created" || i.Status == null).ToListAsync();
            return View(all);
        }
        public async Task<IActionResult> GetAllOrders()
        {
            var all = await orderDbContext.Orders.ToListAsync();
            return View(all);
        }



        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        public async Task<IActionResult> OrderConfirm(long id)
        {
            var order = await orderDbContext.Orders.FirstOrDefaultAsync(i => i.Id == id);
            if (order != null)
            {
                order.Status = "Confirmed";
                orderDbContext.Orders.Update(order);
                await orderDbContext.SaveChangesAsync();
                return RedirectToAction("GetUnconfirmedOrders");
            }
            return NotFound("No order with such id");
        }


        public async Task<IActionResult> RemoveOrder(long id)
        {
            var order = await orderDbContext.Orders.FirstOrDefaultAsync(i => i.Id == id);
            if (order != null)
            {

                orderDbContext.Orders.Remove(order);
                await orderDbContext.SaveChangesAsync();

                return RedirectToAction("GetUnconfirmedOrders");
            }
            return NotFound("No order with such id");
        }
        public async Task<IActionResult> OrderDone(long id)
        {
            var order = await orderDbContext.Orders.FirstOrDefaultAsync(i => i.Id == id);
            if ((order != null) && order.Status != "Done")
            {
                order.Status = "Done";
                orderDbContext.Orders.Update(order);
                await orderDbContext.SaveChangesAsync();

                return RedirectToAction("GetUnconfirmedOrders");
            }
            return NotFound("No order with such id");

        }
    }
}
