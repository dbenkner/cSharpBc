using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Shapes
{
    internal static class GeometricShapeFactory 
    {
        public static OO_Quad CreateInstance(int s1, int s2, int s3, int s4)
        {
            return new OO_Quad(s1, s2, s3, s4);
        }
        public static OO_Rec CreateInstance(int s1, int s2)
        {
            return new OO_Rec(s1, s2);
        }
        public static OO_Square CreateInstance(int s1)
        {
            return new OO_Square(s1);
        }
    }
}
