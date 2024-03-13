using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaibStore.Model.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
        [Required]
        [MaxLength(16)]
        public string Password { get; set; }
        public UserType Type { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Order>? Orders { get; set; }
        public ICollection<BasketPosition>? BasketPositions { get; set; }
    }
}
