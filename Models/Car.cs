using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConcessionariaOnline.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public int? clientId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public bool Sold { get; set; }
        
        [Required]
        public double Price { get; set; }
    }
}
