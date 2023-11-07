using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal interface IExampleForInterface
    {
        int i {get; set;}
        bool b { get; set;}
        string s { get; set;}

        void Print(int n, bool b, string str);
    }
}
