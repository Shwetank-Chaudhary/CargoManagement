using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargoManagement.Models.Entity
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }

        public required string FirstName { get; set; }

        public string? LastName { get; set; }

        
        public City? City { get; set; }
        public required string CityId { get; set; }
        [ForeignKey("CityId")]


        [Phone(ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
