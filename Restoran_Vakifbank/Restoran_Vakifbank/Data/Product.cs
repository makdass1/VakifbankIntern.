using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restoran_Vakifbank.Data
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0.01,2500)]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? SpecialTag { get; set; }
        public int CategoryId { set; get; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string? ImageUrl { get; set; }
    }
}
