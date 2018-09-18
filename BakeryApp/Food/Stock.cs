using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public class Stock
    {
        public int frenchBaguetteStock { get; set; }
        public int softBreadStock { get; set; }
        public int appleSmoothyStock { get; set; }
        public int cokeStock { get; set; }
        public int hamSandwichStock { get; set; }
        public int paniniStock { get; set; }
        public int cookieStock { get; set; }
        public int cheeseCakeStock { get; set; }

        public Stock()
        {
            frenchBaguetteStock = 100;
            softBreadStock = 100;
            appleSmoothyStock = 100;
            cokeStock = 100;
            hamSandwichStock = 100;
            paniniStock = 100;
            cookieStock = 100;
            cheeseCakeStock = 100;
        }
    }
}
