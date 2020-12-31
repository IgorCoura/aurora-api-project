using System;

namespace Aurora.Domain.Models
{
    public class CreatePpeModel
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public String ApprovalCertificate { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int Durability { get; set; }

    }
}
