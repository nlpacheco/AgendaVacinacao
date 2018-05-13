using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.DalcFile
{
    public class VaccineDB : IVaccineDB
    {
        private const string _filename = "AGVVaccine.json";
        GenericFileRepository<Vaccine, Guid> _repository = new GenericFileRepository<Vaccine, Guid>(_filename);

        public IEnumerable<Vaccine> GetAllVaccines()
        {
            return _repository.GetAllEntities();
        }

        public void SaveVaccine(Vaccine vaccine)
        {
            _repository.SaveEntity(vaccine);
        }
    }
}
