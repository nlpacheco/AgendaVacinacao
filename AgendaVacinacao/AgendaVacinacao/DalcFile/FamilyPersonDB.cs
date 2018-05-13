using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaVacinacao.DalcFile
{
    public class FamilyPersonDB : IFamilyPersonDB
    {
        private const string _filename = "AGVfamilyPerson.json";
        GenericFileRepository<FamilyPerson, Guid> _repository = new GenericFileRepository<FamilyPerson, Guid>(_filename);

        public void CancelFamilePerson(FamilyPerson familyPerson)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FamilyPerson> GetFamilyPeople(User user)
        {
            return _repository.GetEntities(p => p.FamilyId == user.FamilyId);
        }

        public void SaveFamilyPerson(FamilyPerson familyPerson)
        {
            _repository.SaveEntity(familyPerson);
        }
    }
}
