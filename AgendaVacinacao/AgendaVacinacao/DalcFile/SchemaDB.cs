using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.DalcFile
{
    public class SchemaDB : ISchemaDB
    {
        private const string _filename = "AGVSchema.json";
        GenericFileRepository<Schema, Guid> _repository = new GenericFileRepository<Schema, Guid>(_filename);

        public Schema GetSchema(Guid schemaId)
        {
           return _repository.GetEntity(schemaId);
        }

        public IEnumerable<Schema> GetSchemas(Guid OwnerPersonId)
        {
            return _repository.GetEntities(s => s.OwnerId == OwnerPersonId);
        }

        public void SaveSchema(Schema schema)
        {
            _repository.SaveEntity(schema);
        }
    }
}
