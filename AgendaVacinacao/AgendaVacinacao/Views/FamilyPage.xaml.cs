using AgendaVacinacao.Models;
using AgendaVacinacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaVacinacao.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FamilyPage : ContentPage
	{
        FamilyViewModel viewModel;

		public FamilyPage (User user)
		{
			InitializeComponent ();

            BindingContext = viewModel = new FamilyViewModel(user);

		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.FamilyPeople.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        async void IncluirPessoa_clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }
    }
}