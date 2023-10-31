﻿using PizzaApp.UI.Services;
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
            MainPage = new NavigationPage(new ListePizzaPage());
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
