using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExamples
{
    internal class BootcampException : Exception
    {
        public int Denominator { get; set; }
        public int Numerator { get; set; } 

        public BootcampException() : base() { } // the three constructors needed to use 

        public BootcampException(string message) : base(message) { }

        public BootcampException(string message, Exception innerException) : base(message, innerException) { }


    }
}
