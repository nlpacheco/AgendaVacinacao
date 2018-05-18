using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaVacinacao.ViewModels
{
    public class VaccineViewModel : BaseViewModel
    {
        public ObservableCollection<Vaccine> Vaccines { get; set; }
        public Command LoadItemsCommand { get; set; }

        public VaccineViewModel()
        {
            Title = "Vacinas";
            Vaccines = new ObservableCollection<Vaccine>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadVaccineCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var _item = item as Item;
            //    Items.Add(_item);
            //    await DataStore.AddItemAsync(_item);
            //});
        }

        async Task ExecuteLoadVaccineCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Vaccines.Clear();

                var vaccineTmp = await CurrentDataStore.CurrentDALC.GetVaccineDBProvider.GetAllVaccines(); 
                foreach (var vacinaItem in vaccineTmp)
                {
                    Vaccines.Add(vacinaItem);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
