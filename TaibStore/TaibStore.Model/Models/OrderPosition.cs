using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaibStore.Model.Models
{
    public class OrderPosition
    {
        [Key]
        public int ID { get; set; }
        public int OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}
