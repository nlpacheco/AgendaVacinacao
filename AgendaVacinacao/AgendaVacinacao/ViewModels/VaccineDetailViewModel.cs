using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.ViewModels
{
    public class VaccineDetailViewModel : BaseViewModel

    {

        public Vaccine Vaccine { get; private set; }

        public VaccineDetailViewModel(Vaccine vaccine)
        {
            Title = vaccine.Name;
            Vaccine = vaccine;
        }
    }
}
