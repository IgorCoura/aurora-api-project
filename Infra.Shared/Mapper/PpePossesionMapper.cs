using Aurora.Domain.Entities;
using Aurora.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Shared.Mapper
{
    public static class PpePossesionMapper
    {
        public static PpePossession ConvertToPpePossessionEntity(this CreatePpePossessionModel ppePossessionModel) =>
            new PpePossession(ppePossessionModel.DeliveryDate, ppePossessionModel.ReturnDate, ppePossessionModel.Confirmation);
        public static PpePossession ConvertToPpePossessionEntity(this CreatePpePossessionModel ppePossessionModel, int id) =>
            new PpePossession(ppePossessionModel.DeliveryDate, ppePossessionModel.ReturnDate, ppePossessionModel.Confirmation, ID: id);

        public static PpePossessionModel ConvertToPpePossession(this PpePossession ppePossession) =>
            new PpePossessionModel(ppePossession.Id, ppePossession.DeliveryDate, ppePossession.ReturnDate, ppePossession.Confirmation, $"Id: {ppePossession.Worker.Id} - Name: {ppePossession.Worker.Name}", $"Id: {ppePossession.PersonalProtectiveEquipment.Id} - Description: {ppePossession.PersonalProtectiveEquipment.Description}");

        public static IEnumerable<PpePossessionModel> ConvertToPpePossession(this IList<PpePossession> PpePossessions) =>
            new List<PpePossessionModel>(PpePossessions.Select(p => new PpePossessionModel(p.Id, p.DeliveryDate, p.ReturnDate, p.Confirmation, $"Id: {p.Worker.Id} - Name: {p.Worker.Name}", $"Id: {p.PersonalProtectiveEquipment.Id} - Description: {p.PersonalProtectiveEquipment.Description}")));
    }
}
