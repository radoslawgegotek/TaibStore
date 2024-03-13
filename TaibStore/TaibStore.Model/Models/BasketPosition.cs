using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaibStore.Model.Models
{
    public class BasketPosition : IEntityTypeConfiguration<BasketPosition>
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public User User { get; set; }
        public int Amount { get; set; }

        public void Configure(EntityTypeBuilder<BasketPosition> builder)
        {
            builder
                .HasOne(x => x.Product)
                .WithMany(x => x.BasketPositions)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.BasketPositions)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
