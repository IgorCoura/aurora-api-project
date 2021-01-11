using Aurora.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Infra.Shared.Mapper;
using Aurora.Domain.Interfaces;
using Aurora.Domain.Entities;

namespace Aurora.Service.Services
{
    public class PpePossessionService: IServicePpePossession
    {
        private readonly IRepositoryPpePossession _repositoryPpePossesion;
        private readonly IRepositoryPpe _repositoryPpe;
        private readonly IRepositoryWorker _repositoryWorker;

        public PpePossessionService(IRepositoryPpePossession repositoryPpePossesion, IRepositoryPpe repositoryPpe, IRepositoryWorker repositoryWorker)
        {
            _repositoryPpePossesion = repositoryPpePossesion;
            _repositoryPpe = repositoryPpe;
            _repositoryWorker = repositoryWorker;
        }

        public void Delete(int id)
        {
            _repositoryPpePossesion.Remove(id);
        }

        public PpePossessionModel Insert(CreatePpePossessionModel ppePossessionModel)
        {
            var ppePossession = ppePossessionModel.ConvertToPpePossessionEntity();
            ppePossession.Worker = _repositoryWorker.GetById(ppePossessionModel.WorkerId);
            ppePossession.PersonalProtectiveEquipment = _repositoryPpe.GetById(ppePossessionModel.PpeId);

            _repositoryPpePossesion.Save(ppePossession);
            return ppePossession.ConvertToPpePossession();
        }

        public IEnumerable<PpePossessionModel> RecoverAll()
        {
            var ppesPossessions = _repositoryPpePossesion.GetAll();
            foreach(PpePossession p in ppesPossessions)
            {
                p.Worker = _repositoryWorker.GetById(p.WorkerId);
                p.PersonalProtectiveEquipment = _repositoryPpe.GetById(p.PersonalProtectiveEquipmentId);
            }
            return ppesPossessions.ConvertToPpePossession();
        }

        public PpePossessionModel RecoverById(int id)
        {
            var ppePossession = _repositoryPpePossesion.GetById(id);
            ppePossession.Worker = _repositoryWorker.GetById(ppePossession.WorkerId);
            ppePossession.PersonalProtectiveEquipment = _repositoryPpe.GetById(ppePossession.PersonalProtectiveEquipmentId);
            return ppePossession.ConvertToPpePossession();
        }

        public PpePossessionModel Update(int id, CreatePpePossessionModel ppePossessionModel)
        {
            var ppePossession = ppePossessionModel.ConvertToPpePossessionEntity(id);
            ppePossession.Worker = _repositoryWorker.GetById(ppePossessionModel.WorkerId);
            ppePossession.PersonalProtectiveEquipment = _repositoryPpe.GetById(ppePossessionModel.PpeId);

            _repositoryPpePossesion.Save(ppePossession);
            return ppePossession.ConvertToPpePossession();
        }
    }
}
