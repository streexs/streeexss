using System;
using System.Formats.Asn1;

using System.Security.Cryptography.X509Certificates;

namespace Prac3
{

    public class HelloWorld
    {

        static double HeronsFormula(double e, double x, double r)
        {
            double s = (e + x + r) / 2;
            double area = Math.Sqrt(s * (s - e) * (s - x) * (s - r));
            return area;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter firt side of Triangle");
            double e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter second side of Triangle");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter third side of Triangle");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = HeronsFormula(e, x, r);

            Console.WriteLine($"the area in triangle is {result}");
        }
    }
}








        