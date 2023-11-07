using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class InterfaceClass : IExampleForInterface
    {
        public int i { get; set; }
        public bool b { get; set; }
        public string s { get; set; }

        public DateTime dt { get; set; }
        public void Print(int n, bool b, string str)
        {
        }
        public void Debug(string s)
        {

        }
    }
}
