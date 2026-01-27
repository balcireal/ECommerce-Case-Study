using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Context;
using ECommerce.Model.Entities;

namespace ECommerce.DataAccess.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}