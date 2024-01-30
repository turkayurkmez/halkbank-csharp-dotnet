using System.ComponentModel.DataAnnotations;

namespace eshop.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public int? Stock { get; set; }
        public string? ImageUrl { get; set; }

        public int? CategoryId { get; set; }

        //Navigation Property
        public Category? Category { get; set; }

    }
}
