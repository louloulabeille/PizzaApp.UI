using PizzaApp.UI.Models;
using PizzaApp.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PizzaApp.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListePizzaPage : ContentPage
    {
        private readonly ListePizzaViewModel ViewModelPizza = new ListePizzaViewModel();

        public ListePizzaPage()
        {
            InitializeComponent();
            
            ViewModelPizza.PizzasAddRange(AjoutePizzas());
            ListePizza.ItemsSource = ViewModelPizza.Pizzas;

            this.BindingContext = this;
            
        }

        // méthode de test pour ajouter des pizzas
        public List<Pizza> AjoutePizzas()
        {
            List<Pizza> pizzas = new List<Pizza>();
            
            /*pizzas.Add(new Pizza()
            {
                Nom = "Sud Ouest",
                Prix = 15.20m,
                Description = "Pizza avec du canard gras.",
                Ingredients = new string[] { "tranche de magret de canard fumé", "gésier de canard confit", "noix" },
                ImageUrl = @"https://img.over-blog-kiwi.com/0/97/63/14/20140919/ob_ae1f56_p1140688-2-pizza-sud-ouest-border.jpg"
            });

            pizzas.Add(new Pizza()
            {
                Nom = "margarita",
                Prix = 10.5m,
                Description = "Pizza avec du jambon et de la mozza.",
                Ingredients = new string[] {"tomate","jambon","mozza"},
                ImageUrl = @"https://images7.alphacoders.com/596/596343.jpg"
            });

            pizzas.Add(new Pizza()
            {
                Nom = "Reine",
                Prix = 11.80m,
                Description = "Pizza avec du jambon, de la mozza et des champignons de Paris.",
                Ingredients = new string[] { "tomate", "jambon", "mozza", "champignon de Paris" },
                ImageUrl = @"https://www.pizza-delea.com/wp-content/uploads/2017/10/REINE-1320x880.jpg"
            });*/
            return pizzas;
        }

    }
}