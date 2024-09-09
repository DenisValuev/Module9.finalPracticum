using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2.Models
{
    internal class NumberException : Exception
    {
        public NumberException(string message) : base(message) { }
    }
}
