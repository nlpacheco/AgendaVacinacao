using System;
using System.Collections.Generic;
using System.Text;
using AgendaVacinacao.Dalc;

namespace AgendaVacinacao.Models
{
    public class FamilyPerson: IGenericDBEntity<Guid>
    {
        public Guid PersonId { get; set; }
        public Guid FamilyId{ get; set; }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Guid Key
        {
            get { return PersonId; }
            set { PersonId = value; }
        }
    }

}

