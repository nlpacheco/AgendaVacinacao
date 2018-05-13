﻿using AgendaVacinacao.Dalc;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.Models
{
    public class User: IGenericDBEntity<string>
    {
        public string Email { get; set; }
        public Guid FamilyId { get; set; }
        public string Name { get; set; }
        public string Key
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}
