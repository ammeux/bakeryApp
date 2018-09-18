using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    class HamSandwich : Sandwich
    {
        public HamSandwich()
        {
            this.price = 4;
            this.vegetarian = false;
            this.ingredients = new string[] { "tomato", "salad", "cheese", "ham", "butter" };
        }
    }
}
