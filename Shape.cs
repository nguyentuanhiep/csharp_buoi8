using System.Collections.Generic;

namespace csharp_buoi8
{
    abstract class Shape
    {
        public string Name { get; set; }
        public abstract void GetArea(double x, double a, double b);
        public abstract void GetPerimeter(double x, double a, double b);
    }

    class Circle : Shape
    {
        public override void GetArea(double x, double a, double b) {
            
            double kq =x*2*3.14;
            
            System.Console.WriteLine("Chu vi hinh tron la {0}", kq);
        }

        public override void GetPerimeter(double x, double a, double b) {
            double kq = x*x*3.14;
            System.Console.WriteLine("Dien tich hinh tron la {0}", kq);
        }
    }

    class Rectangle:Shape
    {
        public override void GetArea(double x, double a, double b) {
            
            double kq =(a + b)*2;
            
            System.Console.WriteLine("Chu vi hinh tron la {0}", kq);
        }

        public override void GetPerimeter(double x, double a, double b) {
            double kq = a*b;
            System.Console.WriteLine("Dien tich hinh tron la {0}", kq);
        }
    }
}