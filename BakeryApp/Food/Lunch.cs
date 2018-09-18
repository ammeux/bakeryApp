using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public class Lunch<V, T> : Menu<T, V> where V : Sandwich where T : Drink
    {
        public Lunch(V first, T second) : base(second, first)
        {
            this.price = 6;
        }
    }
}
