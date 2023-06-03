using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTask3.Models
{
    public class Product

    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal EDV { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal DiscountedPrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]

        public decimal Total => (Price * Quantity - DiscountedPrice) - ((Price * Quantity) * EDV) / 100;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cart => (450 - Total) + EDV * 15 / 100;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cash => (450 - Total) + EDV * 18 / 100;


    }
}
