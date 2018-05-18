using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaVacinacao.Dalc
{
    public interface IFamilyPersonDB
    {
        Task <IEnumerable<FamilyPerson>> GetFamilyPeople(User user);
        Task SaveFamilyPerson(FamilyPerson familyPerson);
        Task CancelFamilePerson(FamilyPerson familyPerson);
    }
}
