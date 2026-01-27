using Microsoft.EntityFrameworkCore;
using ECommerce.Model; 
using ECommerce.Model.Entities;

namespace ECommerce.DataAccess.Context
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}