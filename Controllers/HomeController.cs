using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewShopApp.Models;
using NewShopApp.ModelView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NewShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext applicationContext;
        private readonly IWebHostEnvironment hostingEnvironment;
        public HomeController(ILogger<HomeController> logger, ApplicationContext applicationContext, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            this.applicationContext = applicationContext;
            hostingEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            //   var s = User.FindFirst(ClaimTypes.Email)?.Value;
            return RedirectToAction("All", "Item");
            
        }

      
        [Authorize(Roles ="Admin")]
           
        public async Task<IActionResult> CreateItem(CreateItem item)
        {

            Product item1 = new Product();
            item1.Name = item.Name;
            item1.Category = item.Category;
            item1.Price = item.Price;
            item1.Description = item.Description;
            item1.Quantity = item.Quantity;
            
            if (item.Image != null)
            {
                var uniqueFileName = GetUniqueFileName(item.Image.FileName);

                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                if (!Directory.Exists(uploads))
                {
                    Directory.CreateDirectory(uploads);
                }
                var filePath = Path.Combine(uploads, uniqueFileName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                item.Image.CopyTo(fileStream);
                fileStream.Close();

                item1.Image = uniqueFileName;
              await  applicationContext.Products.AddAsync(item1);
             //   await appDbContext.Items.AddAsync(item1);
                await applicationContext.SaveChangesAsync();

                //to do : Save uniqueFileName  to your db table   
            }
            // to do  : Return something
            return RedirectToAction("Index", "Home");


            // item1.Img = item.FormFile;
            //  var img_tmp = item.FormFile;
        }
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
