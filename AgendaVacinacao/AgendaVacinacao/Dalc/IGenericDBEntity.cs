using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.Dalc
{
    public interface IGenericDBEntity<KeyType>
    {
        KeyType Key { get; set; }
    }
}
