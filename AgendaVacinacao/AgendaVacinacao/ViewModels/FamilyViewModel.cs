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
    public class FamilyViewModel: BaseViewModel
    {
        public User User;
        public ObservableCollection<FamilyPerson> FamilyPeople { get; set; }

        public Command LoadItemsCommand { get; set; }

        public FamilyViewModel(User user)
        {
            User = user;
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                FamilyPeople.Clear();
                var items = await CurrentDataStore.CurrentDALC.GetFamilyPersonDBProvider.GetFamilyPeople(User);
                foreach (var item in items)
                {
                    FamilyPeople.Add(item);
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
