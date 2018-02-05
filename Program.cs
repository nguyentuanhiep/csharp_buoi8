using System;

namespace csharp_buoi8
{
    class Program
    {
        static void Main(string[] args)
        {
           //bai1();
           //bai2();
           bai3();
        }

        static void bai1()
        {
            System.Console.WriteLine("Nhap vao 2 so");
            System.Console.WriteLine("So thu nhat la");
            double x = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("So thu hai la");
            double y = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Tong, Hieu, Tich, Thuong cua 2 so do la");
            Calculator.Add(x,y);
            Calculator.Substract(x,y);
            Calculator.Multiply(x,y);
            Calculator.Divide(x,y);
        }

        static void bai2()
        {
            Circle cir1= new Circle();
            Rectangle rec1= new Rectangle();
            System.Console.WriteLine("Nhap ban kinh hinh tron");
            double x = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Nhap vao chieu dai 2 canh cua hinh chu nhat");
            System.Console.WriteLine("Canh thu nhat la");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Canh thu hai la");
            double b = Convert.ToDouble(Console.ReadLine());
            cir1.GetArea(x,a,b);
            cir1.GetPerimeter(x,a,b);
            rec1.GetArea(x,a,b);
            rec1.GetPerimeter(x,a,b);
        }


        static void bai3()
        {
            Samsung ss1= new Samsung("Android", "Camera with Samsung", "Calling with samsung");
            Iphone ip1 = new Iphone("IOS", "Camera with Iphone", "Calling with Iphone");
            ss1.Info();
            ip1.Info();
        }
    }
}
