using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Domain.Models
{
    public class UpdatePpeModel
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ApprovalCertificate { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int Durability { get; set; }

    }
}
