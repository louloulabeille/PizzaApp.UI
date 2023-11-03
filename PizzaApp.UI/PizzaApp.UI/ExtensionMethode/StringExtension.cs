using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.UI.ExtensionMethode
{
    public static class StringExtension
    {
        public static string PremierLettreMaj(this string str) { 

            if (string.IsNullOrEmpty(str)) return str;
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower(); ; 
        }
    }
}
