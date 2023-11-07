using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class dog : IBreedSpeak
    {
        public string Breed {get; set; }
        public string Color { get; set; }
        public string Speak { get; set; }   
    }
}
