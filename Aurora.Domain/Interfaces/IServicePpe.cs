using Aurora.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Domain.Interfaces
{
    public interface IServicePpe
    {
        PpeModel Insert(CreatePpeModel ppeModel);
        PpeModel Update(int id, UpdatePpeModel ppeModel);
        void Delete(int id);
        PpeModel RecoverById(int id);
        IEnumerable<PpeModel> RecoverAll();
    }
}
