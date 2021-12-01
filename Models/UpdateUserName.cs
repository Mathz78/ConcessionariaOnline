using System.ComponentModel.DataAnnotations.Schema;

namespace ConcessionariaOnline.Models
{
    public class UpdateUserName
    {
        public int UserId { get; set; }

        public string updatedName { get; set; }
    }
}