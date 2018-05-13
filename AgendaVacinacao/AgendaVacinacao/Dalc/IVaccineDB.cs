using System;
using System.Collections.Generic;
using System.Text;
using AgendaVacinacao.Models;

namespace AgendaVacinacao.Dalc
{
    interface IVaccineDB
    {
        IEnumerable<Vaccine> GetAllVaccines();

        void SaveVaccine(Vaccine vaccine);
    }
}
