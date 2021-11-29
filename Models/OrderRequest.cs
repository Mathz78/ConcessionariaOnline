using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ConcessionariaOnline.Models
{
    public class OrderRequest
    {
        public int clientId { get; set; }
        public int carId { get; set; }
    }
}