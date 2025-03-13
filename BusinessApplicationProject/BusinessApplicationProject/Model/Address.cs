using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{
    /// <summary>
    /// Address class
    /// </summary>
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Country { get; set; }
        public required string ZipCode { get; set; }
        public required string City { get; set; }
        public required string StreetAddress { get; set; }
    }
}
