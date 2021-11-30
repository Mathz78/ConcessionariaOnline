using System.ComponentModel.DataAnnotations.Schema;

namespace ConcessionariaOnline.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [ForeignKey("Id")]
        public User User { get; set; }

        public string CPF { get; set; }

        public string Address { get; set; }
    }
}