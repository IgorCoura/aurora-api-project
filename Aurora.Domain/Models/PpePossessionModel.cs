using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Domain.Models
{
    public class PpePossessionModel
    {
        public PpePossessionModel(int id, DateTime deliveryDate, DateTime? returnDate, bool confirmation, string worker, string personalProtectiveEquipment)
        {
            Id = id;
            DeliveryDate = deliveryDate;
            ReturnDate = returnDate;
            Confirmation = confirmation;
            Worker = worker;
            PersonalProtectiveEquipment = personalProtectiveEquipment;
        }

        public int Id { get; set; }
        public DateTime DeliveryDate { get; set;}

        public DateTime? ReturnDate { get; set;}

        public bool Confirmation { get; set;}

        public string Worker { get; set; }
        public string PersonalProtectiveEquipment { get; set; }
    }
}
