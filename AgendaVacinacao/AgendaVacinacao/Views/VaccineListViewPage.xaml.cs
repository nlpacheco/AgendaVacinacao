using AgendaVacinacao.Models;
using AgendaVacinacao.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaVacinacao.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VaccineListViewPage : ContentPage
    {
        public ObservableCollection<string> Vaccines { get; set; }

        VaccineViewModel viewModel;

        public VaccineListViewPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new VaccineViewModel();
            //VaccineListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        async void AddNewItem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Add Item", "Add button clicked.", "OK");
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var vaccine = args.SelectedItem as Vaccine;
            if (vaccine == null)
                return;

            await Navigation.PushAsync(new VaccineDetailPage(vaccine));

            // Manually deselect item.
            VaccineListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Vaccines.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

    }
}
