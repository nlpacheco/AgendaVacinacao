using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaVacinacao.DalcFile
{
    public class SchemaDB : ISchemaDB
    {
        private const string _filename = "AGVSchema.json";
        GenericFileRepository<Schema, Guid> _repository = new GenericFileRepository<Schema, Guid>(_filename);

        public async Task <Schema> GetSchema(Guid schemaId)
        {
           return await _repository.GetEntityAsync(schemaId);
        }

        public async Task<IEnumerable<Schema>> GetSchemas(Guid OwnerPersonId)
        {
            return await _repository.GetEntitiesAsync(s => s.OwnerId == OwnerPersonId);
        }

        public async Task SaveSchema(Schema schema)
        {
            await _repository.SaveEntityAsync(schema);
        }
    }
}
