using System.Collections.Generic;
namespace csharp_buoi8
{
    static class Calculator
    {
        public static void Add (double x, double y) {
            System.Console.WriteLine(x+y);
        }

        public static void Substract (double x, double y) {
            System.Console.WriteLine(x-y);
        }

        public static void Multiply (double x, double y) {
            System.Console.WriteLine(x*y);
        }

        public static void Divide (double x, double y) {
            double z = (double)x/(double)y;
            System.Console.WriteLine(z);
        }
    }
}