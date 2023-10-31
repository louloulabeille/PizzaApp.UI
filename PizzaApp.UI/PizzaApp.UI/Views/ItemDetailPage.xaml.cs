﻿using PizzaApp.UI.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PizzaApp.UI.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}