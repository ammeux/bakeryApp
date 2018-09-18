using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public abstract class Bread : IFood
    {
        public Bread(double price, int calories)
        {
            this.price = price;
            this.calories = calories;
        }

        public int calories { get; } = 0;

        public double price { get; } = 0;

        public int bakingTime { get; set; } = 0;
    }
}
