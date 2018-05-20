using System;
using System.Collections.Generic;
using System.Text;
using AgendaVacinacao.Dalc;
using AgendaVacinacao.DalcFile;
using AgendaVacinacao.Shared.NavController;

namespace AgendaVacinacao
{
    public static class AppSettings
    {



        public static void AppSet()
        {
            CurrentDataStore.CurrentDALC = new FileDataStore();
            MockVaccineDatabase.MockVaccineDataStore();


            MapWorkflow();
        }

        static void MapWorkflow()
        {
        }

    }
}
