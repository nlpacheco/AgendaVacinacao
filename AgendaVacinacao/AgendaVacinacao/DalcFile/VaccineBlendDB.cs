using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaVacinacao.DalcFile
{
    public class VaccineBlendDB : IVaccineBlendDB
    {
        private const string _filename = "AGVVaccineBlend.json";
        GenericFileRepository<VaccineBlend, Guid> _repository = new GenericFileRepository<VaccineBlend, Guid>(_filename);

        public async Task<IEnumerable<VaccineBlend>> GetAllBlends()
        {
            return await _repository.GetAllEntitiesAsync();
        }

        public async Task SaveBlend(VaccineBlend blend)
        {
            await _repository.SaveEntityAsync(blend);
        }

        public async Task SaveAllBlends(IEnumerable<VaccineBlend> blends)
        {
            await _repository.SaveAllEntitiesAsync(blends);
        }
    }
}
