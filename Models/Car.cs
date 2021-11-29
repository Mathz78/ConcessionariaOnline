using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConcessionariaOnline.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("IdCliente")]
        public int? clientId { get; set; }

        [Required]
        [JsonProperty("Nome")]
        public string Name { get; set; }

        [Required]
        [JsonProperty("Modelo")]
        public string Model { get; set; }

        [Required]
        [JsonProperty("Marca")]
        public string Brand { get; set; }

        [Required]
        [JsonProperty("Ano")]
        public string Year { get; set; }

        [Required]
        [JsonProperty("Vendido")]
        public bool Sold { get; set; }
        
        [Required]
        [JsonProperty("Preco")]
        public double Price { get; set; }
    }
}
