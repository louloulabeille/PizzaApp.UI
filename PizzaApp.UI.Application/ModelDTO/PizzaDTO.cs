using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.UI.Application.ModelDTO
{
    [Serializable]
    public class PizzaDTO
    {
        public string Nom;
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public IngredientDTO[] Ingredients { get; set; }
        public string ImageUrl { get; set; }
    }
}
