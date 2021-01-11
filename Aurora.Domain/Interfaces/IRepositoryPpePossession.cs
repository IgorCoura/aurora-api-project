using Aurora.Domain.Entities;
using System.Collections.Generic;

namespace Aurora.Domain.Interfaces
{
    public interface IRepositoryPpePossession
    {
        IList<PpePossession> GetAll();
        PpePossession GetById(int id);
        void Remove(int id);
        void Save(PpePossession obj);
    }
}