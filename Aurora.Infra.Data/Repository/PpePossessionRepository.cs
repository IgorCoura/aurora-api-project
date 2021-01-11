using Aurora.Domain.Entities;
using Aurora.Domain.Interfaces;
using Aurora.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Infra.Data.Repository
{
    public class PpePossessionRepository : BaseRepository<PpePossession, int>, IRepositoryPpePossession
    {
        public PpePossessionRepository(MySqlContext mySqlContext) : base(mySqlContext)
        {

        }

        public void Remove(int id)
        {
            base.Delete(id);
            base.SaveChanges();
        }

        public void Save(PpePossession obj)
        {
            if (obj.Id == 0)
            {
                base.Insert(obj);
            }
            else
            {
                base.Update(obj);
            }
        }

        public PpePossession GetById(int id) =>
            base.Select(id);

        public IList<PpePossession> GetAll() =>
            base.Select();
    }
}
