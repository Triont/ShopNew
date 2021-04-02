using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace NewShopApp.Models
{
    
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
    //    public virtual DbSet<ApplicationUser> DbSet { get; set; }
  //  public DbSet<Product> Products { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
          // Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.Price)
                   .IsRequired();
                entity.Property(e => e.Quantity)
                   .IsRequired();
                  

            });

            base.OnModelCreating(builder);
        }
    }
}
