using Aurora.Domain.Entities;
using Aurora.Domain.Interfaces;
using Aurora.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Infra.Data.Repository
{
    public class PpeRepository : BaseRepository<PersonalProtectiveEquipment, int>, IRepositoryPpe
    {
        public PpeRepository(MySqlContext mySqlContext) : base(mySqlContext)
        {

        }

        public void Remove(int id)
        {
            base.Delete(id);
            base.SaveChanges();
        }

        public void Save(PersonalProtectiveEquipment obj)
        {
            if(obj.Id == 0)
            {
                base.Insert(obj);
            }
            else
            {
                base.Update(obj);
            }
        }

        public PersonalProtectiveEquipment GetById(int id) =>
            base.Select(id);

        public IList<PersonalProtectiveEquipment> GetAll() =>
            base.Select();
    }
}
