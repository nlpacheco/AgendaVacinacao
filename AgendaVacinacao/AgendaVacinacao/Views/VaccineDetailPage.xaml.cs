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
	public partial class VaccineDetailPage : ContentPage
	{
        public VaccineDetailViewModel viewModel;

		public VaccineDetailPage (Vaccine vaccine)
		{
			InitializeComponent ();
            BindingContext = viewModel = new VaccineDetailViewModel(vaccine);
		}
	}
}