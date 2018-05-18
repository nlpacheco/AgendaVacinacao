using System;
using AgendaVacinacao.Dalc;
using AgendaVacinacao.DalcFile;
using AgendaVacinacao.Views;
using Xamarin.Forms;

namespace AgendaVacinacao
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            CurrentDataStore.CurrentDALC = new FileDataStore();
            new MockVaccineDatabase();

            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
