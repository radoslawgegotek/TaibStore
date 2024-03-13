using System.ComponentModel.DataAnnotations;

namespace TaibStore.Model.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }

        public ICollection<BasketPosition>? BasketPositions { get; set; }
    }
}
