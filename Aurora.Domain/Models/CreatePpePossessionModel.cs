using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Domain.Models
{
    public class CreatePpePossessionModel
    {
        public DateTime DeliveryDate { get; set;}

        public DateTime? ReturnDate { get; set;}

        public bool Confirmation { get; set; }
        public int PpeId { get; set; }
        public int WorkerId { get; set; }
    }
}
