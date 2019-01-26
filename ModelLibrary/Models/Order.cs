using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Customer Customer { get; set; }
    }
}
