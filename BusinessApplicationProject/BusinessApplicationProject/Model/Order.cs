using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{
    /// <summary>
    /// Order class
    /// </summary>
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string OrderNumber { get; set; }
        public DateTime Date { get; set; }

        public required int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public required Customer CustomerDetails { get; set; }

        public required ICollection<Position> Positions { get; set; }
    }
}
