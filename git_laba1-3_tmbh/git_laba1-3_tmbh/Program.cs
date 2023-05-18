using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace git_laba1_3_tmbh
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            Console.WriteLine("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;
         
           
                x1 = (-b + Sqrt(d)) / (2 * a);
                x2 = (-b - Sqrt(d)) / (2 * a);
            
           
            if (x1 > x2) {Console.WriteLine($"x2={x2},x1={x1}"); }
            else if (x2 > x1) { Console.WriteLine($"x1={x1},x2={x2}"); }
            else { Console.WriteLine($"корни равны {x1}"); }
        }
    }
}
