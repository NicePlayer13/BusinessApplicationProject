using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject.Model
{/// <summary>
/// Customer class
/// </summary>
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



        public required int CustomerAddressId { get; set; }
        [ForeignKey(nameof(CustomerAddressId))]
        
        public Address? CustomerAddress { get; set; }  
    }
}
