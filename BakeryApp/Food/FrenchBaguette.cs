using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    class FrenchBaguette : Bread
    {
        public FrenchBaguette() : base(0.8, 700)
        {
            this.bakingTime = 20;
        }
    }
}
