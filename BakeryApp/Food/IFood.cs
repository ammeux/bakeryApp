﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Food
{
    public interface IFood
    {
        double price { get; }
        int calories { get; }
    }
}
