using System;
using System.Collections.Generic;
using System.Text;
using AgendaVacinacao.Dalc;

namespace AgendaVacinacao.Models
{
    public class VaccineBlend : IGenericDBEntity<Guid>
    {
        public Guid BlendId { get; set; }
        public IEnumerable<VaccineType> VaccineTypes { get; set; }

        public Guid Key
        {
            get { return BlendId; }
            set { BlendId = value; }
        }

    }
}
