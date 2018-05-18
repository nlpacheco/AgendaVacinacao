using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using AgendaVacinacao.Models;

namespace AgendaVacinacao.Dalc
{
    public interface IVaccineDB
    {
        Task<IEnumerable<Vaccine>> GetAllVaccines();

        Task SaveVaccine(Vaccine vaccine);
        Task SaveAllVaccines(IEnumerable<Vaccine> vaccines);
    }
}
