using System;
using System.Collections.Generic;
using System.Text;
using AgendaVacinacao.Dalc;

namespace AgendaVacinacao.Models
{
    public class Schema : IGenericDBEntity<Guid>
    {
        public Guid SchemaId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? BaseSchemaId { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<SchemaVaccine> schemaVaccines { get; set; }

        public Guid Key
        {
            get { return SchemaId; }
            set { SchemaId = value; }
        }

    }
}
