using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaVacinacao.DalcFile
{
    public class FamilyPersonDB : IFamilyPersonDB
    {
        private const string _filename = "AGVfamilyPerson.json";
        GenericFileRepository<FamilyPerson, Guid> _repository = new GenericFileRepository<FamilyPerson, Guid>(_filename);

        public async Task CancelFamilePerson(FamilyPerson familyPerson)
        {
            throw new NotImplementedException();
        }

        public async Task <IEnumerable<FamilyPerson>> GetFamilyPeople(User user)
        {
            return await _repository.GetEntitiesAsync(p => p.FamilyId == user.FamilyId);
        }

        public async Task SaveFamilyPerson(FamilyPerson familyPerson)
        {
            await _repository.SaveEntityAsync(familyPerson);
        }
    }
}
