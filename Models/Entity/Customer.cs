using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargoManagement.Models.Entity
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Not a valid phone number")]
        public string CustomerPhone { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [ForeignKey("CityId")]
        public int CityId { get; set; }

        public City? City { get; set; }
    }
}
