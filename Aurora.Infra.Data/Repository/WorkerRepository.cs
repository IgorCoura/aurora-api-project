using System.Collections.Generic;
using Aurora.Domain.Entities;
using Aurora.Domain.Interfaces;
using Aurora.Infra.Data.Context;

namespace Aurora.Infra.Data.Repository
{
    public class WorkerRepository : BaseRepository<Worker, int>, IRepositoryWorker
    {
        public WorkerRepository(MySqlContext mySqlContext) : base(mySqlContext)
        {
        }

        public void Remove(int id)
        {
            base.Delete(id);
            base.SaveChanges();
        }
            
        

        public void RemoveAll()
        {
            var ent = Select();
            foreach(var e in ent)
            {
                base.Delete(e.Id);
            }
            base.SaveChanges();
        }

        public void Save(Worker obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            else
                base.Update(obj, _mySqlContext.Entry(obj).Property(prop => prop.Password));
        }

        public Worker GetById(int id) =>
            base.Select(id);

        public IList<Worker> GetAll() =>
            base.Select();

    }
}
