using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{
    /// <summary>
    /// Position class
    /// </summary>
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int PositionNumber { get; set; }

        public required int ArticleId { get; set; }

        [ForeignKey(nameof(ArticleId))]
        public virtual Article? ArticleDetails { get; set; } // ✅ Allow Lazy Loading & Nullable

        public int Quantity { get; set; }

        public required int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order? OrderDetails { get; set; } // ✅ Allow Lazy Loading & Nullable
    }
}
