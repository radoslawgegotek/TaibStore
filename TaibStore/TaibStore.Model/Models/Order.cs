using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaibStore.Model.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public User User { get; set; }
        public DateTime Date { get; set; }

        public ICollection<OrderPosition>? OrderPositions { get; set; }
    }
}
