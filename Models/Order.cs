using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConcessionariaOnline.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public DateTime? CheckoutDate { get; set; }
    }
}
