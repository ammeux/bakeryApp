using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public class Menu<T, V> where T : IFood where V : IFood
    {
        public IFood drink { get; set; }
        public IFood meal { get; set; }
        public double price { get; set; }

        public Menu(T first, V second)
        {
            drink = first;
            meal = second;
        }
    }
}
