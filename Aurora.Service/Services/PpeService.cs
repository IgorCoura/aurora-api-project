using Aurora.Domain.Interfaces;
using Aurora.Domain.Models;
using Infra.Shared.Contexts;
using Infra.Shared.Mapper;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Aurora.Service.Services
{
    public class PpeService : IServicePpe
    {
        private readonly IRepositoryPpe _repositoryPpe;
        private readonly NotificationContext _notificationContext;

        public PpeService(IRepositoryPpe repositoryPpe, NotificationContext notificationContext)
        {
            _repositoryPpe = repositoryPpe;
            _notificationContext = notificationContext;
        }
        public void Delete(int id)
        {
            _repositoryPpe.Remove(id);
        }

        public PpeModel Insert(CreatePpeModel ppeModel)
        {
            var ppe = ppeModel.ConvertToPpeEntity();
            _notificationContext.AddNotifications(ppe.Notifications);

            if (_notificationContext.Invalid)
                return default;

            _repositoryPpe.Save(ppe);
            return ppe.ConvertToPpe();
        }

        public IEnumerable<PpeModel> RecoverAll()
        {
            var ppe = _repositoryPpe.GetAll();
            return ppe.ConvertToPpe();
        }

        public PpeModel RecoverById(int id)
        {
            var ppe = _repositoryPpe.GetById(id);
            return ppe.ConvertToPpe();
        }

        public PpeModel Update(int id, UpdatePpeModel ppeModel)
        {
            var ppe = ppeModel.ConvertToPpeEntity(id);
            _notificationContext.AddNotifications(ppe.Notifications);

            if (_notificationContext.Invalid)
            {
                return default;
            }

            _repositoryPpe.Save(ppe);
            return ppe.ConvertToPpe();
        }
    }
}
