using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.Dalc
{
    interface IVaccineBlendDB
    {
        IEnumerable<VaccineBlend> GetAllBlends();

        void SaveBlend(VaccineBlend blend);

        void SaveAllBlends(IEnumerable<VaccineBlend> blends);
    }
}
