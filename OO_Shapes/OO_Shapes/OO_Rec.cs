using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Shapes
{
    internal class OO_Rec : OO_Quad
    {
        public OO_Rec(int s1, int s2) : base(s1, s2, s1, s2)
        {

        }
        public int Area()
        {
            return side1 * side2;
        }
    }
}
