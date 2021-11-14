using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ConcessionariaOnline.Models
{
    public class User
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Required]
        [JsonProperty("Nome")]        
        public string Name { get; set; }
        
        [Required]
        [JsonProperty("UltimoNome")]
        public string LastName { get; set; }

        [Required]
        [JsonProperty("Email")]
        public string Email { get; set; }

        [Required]
        [JsonProperty("Senha")]
        public string Password { get; set; }
    }
}