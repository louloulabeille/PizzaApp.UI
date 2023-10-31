using PizzaApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.UI.ViewModels
{
    public class ListePizzaViewModel : BaseViewModel
    {
        public IList<Pizza> Pizzas = new List<Pizza>();
        public ListePizzaViewModel() { }

        public void PizzasAddRange(List<Pizza> pizzas)
        {
            Pizzas.Clear();
            foreach (Pizza p in pizzas) { Pizzas.Add(p); }
        }
    }
}
