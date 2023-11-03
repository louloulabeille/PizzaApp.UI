using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.UI.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Nom { get; set; }

       // [NotMapped]
       /* [JsonIgnore]
        public ICollection<Pizza>? pizzas { get; set; }*/
    }
}
