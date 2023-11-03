﻿using PizzaApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PizzaApp.UI.ViewModels
{
    public class ListePizzaViewModel : BaseViewModel
    {
        public ICollection<Pizza> _pizzas = new List<Pizza>();
        public ICollection<Pizza> Pizzas {  get { return _pizzas; } }

        public ListePizzaViewModel() { }

        public void PizzasAddRange(List<Pizza> pizzas)
        {
            Pizzas.Clear();
            foreach (Pizza p in pizzas) { Pizzas.Add(p); }
        }

    }
}
