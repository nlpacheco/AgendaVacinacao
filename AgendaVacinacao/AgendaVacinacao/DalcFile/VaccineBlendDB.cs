using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.DalcFile
{
    public class VaccineBlendDB : IVaccineBlendDB
    {
        private const string _filename = "AGVVaccineBlend.json";
        GenericFileRepository<VaccineBlend, Guid> _repository = new GenericFileRepository<VaccineBlend, Guid>(_filename);

        public IEnumerable<Models.VaccineBlend> GetAllBlends()
        {
            return _repository.GetAllEntities();
        }

        public void SaveBlend(Models.VaccineBlend blend)
        {
            _repository.SaveEntity(blend);
        }

        public void SaveAllBlends(IEnumerable<VaccineBlend> blends)
        {
            _repository.SaveAllEntities(blends);
        }
    }
}
