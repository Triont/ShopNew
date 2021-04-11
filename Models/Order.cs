using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewShopApp.Models
{
    public class Order
    {
        public long Id { get; init; }
        public string OrderItems { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        
        [Column(TypeName = "decimal(7, 2)")]
        public decimal TotalPrice { get; set; }
    }
    public class OrderDbContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options) { }

    }
    public enum StatusCode:int
    {

    }
}
