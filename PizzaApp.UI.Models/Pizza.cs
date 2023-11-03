using PizzaApp.UI.ExtensionMethode;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.UI.Models
{
    public class Pizza
    {
        private string _nom;
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string[] Ingredients { get; set; }
        public string ImageUrl { get; set; }

        public string Nom
        {
            get { return _nom.PremierLettreMaj(); }
            set { _nom = value; }
        }

        public string StringIngredients { get
            {
                string result = string.Empty;
                foreach (var item in Ingredients)
                {
                    result += item.ToString() + " ";
                }
                return result.Trim();
            } 
        }

    }
}
