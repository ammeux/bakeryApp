using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public class Sandwich : IFood
    {
        public int calories { get; set; }

        public double price { get; set; }

        public bool vegetarian { get; set; } = false;

        public string[] ingredients;
    }
}
