using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public class Dessert : IFood
    {
        public int calories { get; set; }

        public double price { get; set; }
    }
}
