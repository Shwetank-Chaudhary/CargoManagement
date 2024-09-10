﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargoManagement.Models.Entity
{
    public class CargoOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]

        public Customer? Customer { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ShipDate { get; set; }
    }
}
