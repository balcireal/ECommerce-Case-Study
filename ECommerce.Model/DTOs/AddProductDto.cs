using System.ComponentModel.DataAnnotations;

namespace ECommerce.Model.DTOs
{
    public class AddProductDto
    {
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}