using System;

namespace ConcessionariaOnline.Models
{
    public class OrderReponse
    {
        public string Status { get; set; }

        public string Message { get; set; }

        public double Price { get; set; }

        public DateTime? OrderDate { get; set; }
    }
}