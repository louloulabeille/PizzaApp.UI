using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.UI.Models
{
    public class Pizza
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string[] Ingredients { get; set; }

    }
}
