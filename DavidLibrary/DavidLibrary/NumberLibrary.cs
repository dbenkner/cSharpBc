using System.Reflection.Metadata.Ecma335;

namespace DavidLibrary
{
    public static class NumberLibrary
    {
        public static double PI = 3.1415;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Modulo(int a, int b)
        {
            return a - (a / b * b);
        }
        public static int Cubed(int a)
        {
            return a * a * a;
        }
        public static bool IsEven(int a)
        {
            return Modulo(a, 2) == 0;
        }
        public static bool IsOdd(int a)
        {
            return !IsEven(a);
        }
    }
}