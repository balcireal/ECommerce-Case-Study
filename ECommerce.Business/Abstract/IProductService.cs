using ECommerce.Model.DTOs;
using ECommerce.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(int id);
        Task<Product> AddAsync(AddProductDto addProductDto);
        Task DeleteAsync(int id);
    }
}