using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public abstract class Drink : IFood
    {
        public int calories { get; set; }

        public double price { get; set; }

        public bool can { get; set; } = false;
    }
}
