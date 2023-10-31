using PizzaApp.UI.Services;
using PizzaApp.UI.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PizzaApp.UI
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();

            var navigationPage = new NavigationPage(new ListePizzaPage());
            navigationPage.BarBackgroundColor = Color.FromHex("#1abbd4");                
            MainPage = navigationPage;
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
