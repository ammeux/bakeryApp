using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.ExceptionHandlers
{
    class maxStockAddException : Exception
    {

        public maxStockAddException(string message) : base(message) { }
    }
}
