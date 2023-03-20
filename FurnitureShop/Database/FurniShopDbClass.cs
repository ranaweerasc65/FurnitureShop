using FurnitureShop.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



public class FurniShopDbClass : DbContext
{
    public FurniShopDbClass(DbContextOptions<FurniShopDbClass> options)
        : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Admin> Admins { get; set; }
   // public DbSet<FurniShopDbClass.Models.Admin> Admin_1 { get; set; }
}