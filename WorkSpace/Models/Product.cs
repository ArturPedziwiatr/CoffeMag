using System.ComponentModel.DataAnnotations;

namespace WorkSpace.Entities
{
    public class Product
    {
        public Guid Id { get;  set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int? Number { get; set; } 
        public int? Quantity { get; set; }
        [StringLength(200)]
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
