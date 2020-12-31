using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Domain.Models
{
    public class PpeModel
    {
        public PpeModel(int id, string description, int quantity, string approvalCertificate, DateTime manufacturingDate, int durability)
        {
            Id = id;
            Description = description;
            Quantity = quantity;
            ApprovalCertificate = approvalCertificate;
            ManufacturingDate = manufacturingDate;
            Durability = durability;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ApprovalCertificate { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int Durability { get; set; }


    }
}
