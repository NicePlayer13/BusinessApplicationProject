using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject
{
    /// <summary>
    /// Represents a customer's order containing multiple positions.
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
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
