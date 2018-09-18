using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public class Breakfast<V, T> : Menu<T, V> where V: Bread where T: Drink
    {
        public Breakfast(V first, T second) : base(second, first)
        {
            this.price = 4;
        }
    }
}
