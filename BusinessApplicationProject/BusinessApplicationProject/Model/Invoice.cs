using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{
    /// <summary>
    /// Invoice class
    /// </summary>
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string InvoiceNumber { get; set; }
        public DateTime DueDate { get; set; }

        public required int BillingAddressId { get; set; }
        [ForeignKey(nameof(BillingAddressId))]
        public required Address BillingAddress { get; set; }

        public double Discount { get; set; }
        public double TaxPercentage { get; set; }

        public required string PaymentMethod { get; set; }
        public required string PaymentStatus { get; set; }

        public required int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public required Order OrderInformations { get; set; }
    }
}
