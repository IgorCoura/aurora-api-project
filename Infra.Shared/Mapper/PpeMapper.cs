using Aurora.Domain.Entities;
using Aurora.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Shared.Mapper
{
    public static class PpeMapper
    {
        public static PersonalProtectiveEquipment ConvertToPpeEntity(this CreatePpeModel ppeModel) =>
            new PersonalProtectiveEquipment(0, ppeModel.Description, ppeModel.Quantity, ppeModel.ApprovalCertificate, ppeModel.ManufacturingDate, ppeModel.Durability);
            
        public static PersonalProtectiveEquipment ConvertToPpeEntity(this UpdatePpeModel ppeModel, int id) =>
            new PersonalProtectiveEquipment(id, ppeModel.Description, ppeModel.Quantity, ppeModel.ApprovalCertificate, ppeModel.ManufacturingDate, ppeModel.Durability);

        public static IEnumerable<PpeModel> ConvertToPpe(this IList<PersonalProtectiveEquipment> ppe) =>
            new List<PpeModel>(ppe.Select(s => new PpeModel(s.Id, s.Description.ToString(), s.Quantity, s.ApprovalCertificate.ToString(), s.ManufacturingDate, s.Durability)));

        public static PpeModel ConvertToPpe(this PersonalProtectiveEquipment ppe) => 
            new PpeModel(ppe.Id, ppe.Description.ToString(), ppe.Quantity, ppe.ApprovalCertificate.ToString(), ppe.ManufacturingDate, ppe.Durability);
    }
}
