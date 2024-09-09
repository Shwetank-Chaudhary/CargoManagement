using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargoManagement.Models.Entity
{
    public class CargoOrder
    {
        [Key]
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]

        public Customer? Customer { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
    }
}
