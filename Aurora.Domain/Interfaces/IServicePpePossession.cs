using Aurora.Domain.Entities;
using Aurora.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Domain.Interfaces
{
    public interface IServicePpePossession
    {        void Delete(int id);
        PpePossessionModel Insert(CreatePpePossessionModel ppeModel);
        IEnumerable<PpePossessionModel> RecoverAll();
        PpePossessionModel RecoverById(int id);
        PpePossessionModel Update(int id, CreatePpePossessionModel ppeModel);
    }
}
