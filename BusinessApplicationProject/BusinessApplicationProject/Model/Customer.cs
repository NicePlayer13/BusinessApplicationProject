using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessApplicationProject;
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject
{
    /// <summary>
    /// Represents a customer in the application.
    /// </summary>
    [Serializable]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public required string CustomerNumber { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Website { get; set; }
        public string? PasswordHash { get; set; }


        public required int CustomerAddressId { get; set; }
        [ForeignKey(nameof(CustomerAddressId))]
        public Address? CustomerAddress { get; set; }
    }
}
