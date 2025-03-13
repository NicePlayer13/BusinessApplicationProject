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
        public required Article ArticleDetails { get; set; }

        public int Quantity { get; set; }

        public required int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public required Order OrderDetails { get; set; }
    }
}
