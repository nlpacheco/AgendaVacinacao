using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using AgendaVacinacao.Shared.NavController;
using AgendaVacinacao.Views;

namespace AgendaVacinacao
{
	public partial class App : Application
	{
        public static App Instance => (App)Current;

        public readonly INavigationService NavigationService;
        public readonly INavController NavController;


        public App ()
		{
			InitializeComponent();

            
            IDictionary<NavigationController.Map, Type> fullmap = new Dictionary<NavigationController.Map, Type>
            {
                { NavigationController.Map.Create(0, typeof(Views.MainPage)), typeof(AboutPage) },
                { NavigationController.Map.Create(1, typeof(Views.MainPage)), typeof(VaccineListViewPage) }
            };


            NavigationService = new NavigationService(new MainPage());
            NavController = new NavigationController(NavigationService, fullmap);
            AppSettings.AppSet();



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
