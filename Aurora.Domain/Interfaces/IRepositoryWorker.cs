using System.Collections.Generic;
using Aurora.Domain.Entities;

namespace Aurora.Domain.Interfaces
{
    public interface IRepositoryWorker
    {
        void Save(Worker obj);

        void Remove(int id);

        void RemoveAll();

        Worker GetById(int id);

        IList<Worker> GetAll();
    }
}

