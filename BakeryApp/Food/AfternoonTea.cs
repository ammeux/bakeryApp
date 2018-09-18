using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public class AfternoonTea<V, T>: Menu<T, V> where V: Dessert where T: Drink
    {
        public AfternoonTea(V first, T second) : base(second, first)
        {
            this.price = 5;
        }
    }
}
