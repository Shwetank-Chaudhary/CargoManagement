using System.ComponentModel.DataAnnotations;

namespace CargoManagement.Models.Entity
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; } = string.Empty;
    }
}
