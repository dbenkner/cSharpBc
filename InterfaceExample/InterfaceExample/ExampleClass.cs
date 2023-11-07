using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class ExampleClass
    {
        public IExampleForInterface ic { get; set; }
        
        public ExampleClass() { 
       
            ic = new InterfaceClass();
            ic.i = 1;
            ic.b = true;
            ic.s = "string";
            ic.Print(ic.i, ic.b, ic.s);
        }

    }
}
