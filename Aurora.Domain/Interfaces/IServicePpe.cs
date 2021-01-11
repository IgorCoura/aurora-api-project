using Aurora.Domain.Models;
using System.Collections.Generic;

namespace Aurora.Domain.Interfaces
{
    public interface IServicePpe
    {
        void Delete(int id);
        PpeModel Insert(CreatePpeModel ppeModel);
        IEnumerable<PpeModel> RecoverAll();
        PpeModel RecoverById(int id);
        PpeModel Update(int id, UpdatePpeModel ppeModel);
    }
}