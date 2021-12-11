using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ConcessionariaOnline.Models
{
    public class UserResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }
}