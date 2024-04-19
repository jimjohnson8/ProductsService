using System.ComponentModel.DataAnnotations;

namespace ProductsService.Models
{
    public class Product
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Range(0.00, double.MaxValue, ErrorMessage = "Price cannot be negative")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "Description is required")]
        public required string Description { get; set; }
        
        [Required(ErrorMessage = "Category is required")]
        public required string Category { get; set; }
    }
}
