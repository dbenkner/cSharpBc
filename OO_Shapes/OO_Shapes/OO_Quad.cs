using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Shapes
{
    internal class OO_Quad : Shape
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int side4 { get; set; }
        public int Perimeter()
        {
            return side1 + side2 + side3 + side4;
        }
        public OO_Quad(int s1, int s2, int s3, int s4) : base() 
        {
            side1 = s1; side2 = s2; side3 = s3; side4 = s4; 
        }
    }
}
