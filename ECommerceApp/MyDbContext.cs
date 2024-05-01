using ECommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Login> Login {  get; set; }

        
    }
}
