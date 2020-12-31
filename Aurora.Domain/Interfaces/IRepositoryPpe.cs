using Aurora.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Domain.Interfaces
{
    public interface IRepositoryPpe
    {
        void Save(PersonalProtectiveEquipment obj);
        void Remove(int id);
        PersonalProtectiveEquipment GetById(int id);
        IList<PersonalProtectiveEquipment> GetAll();
    }
}
