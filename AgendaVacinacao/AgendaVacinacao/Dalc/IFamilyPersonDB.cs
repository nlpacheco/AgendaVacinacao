using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.Dalc
{
    interface IFamilyPersonDB
    {
        IEnumerable<FamilyPerson> GetFamilyPeople(User user);
        void SaveFamilyPerson(FamilyPerson familyPerson);
        void CancelFamilePerson(FamilyPerson familyPerson);
    }
}
