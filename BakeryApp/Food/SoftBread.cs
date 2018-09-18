using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    class SoftBread : Bread
    {
        public SoftBread() : base(1.2, 500)
        {
            this.bakingTime = 30;
        }
    }
}
