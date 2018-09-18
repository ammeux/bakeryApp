using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    class Panini : Sandwich
    {
        public Panini()
        {
            this.price = 3.5;
            this.vegetarian = true;
            this.ingredients = new string[] { "tomato", "salad", "cucumber", "avocado", "cheese" };
        }
    }
}
