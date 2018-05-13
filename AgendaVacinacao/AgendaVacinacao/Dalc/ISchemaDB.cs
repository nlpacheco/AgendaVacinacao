using System;
using System.Collections.Generic;
using System.Text;
using AgendaVacinacao.Models;

namespace AgendaVacinacao.Dalc
{
    interface ISchemaDB
    {
        Schema GetSchema(Guid schemaId);
        IEnumerable<Schema> GetSchemas(Guid OwnerPersonId);
        void SaveSchema(Schema schema);
    }
}
