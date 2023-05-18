using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace git_laba1_4_tmbh
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, a, x, y1, b;
            Console.WriteLine("a=");  a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b="); b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x="); x = Convert.ToDouble(Console.ReadLine());
            y = Pow(-a, 5) * x + Pow(Cos(Pow(x, 2)), 4) + b*x;
            y1 = (Sqrt(Abs(-a * x + y)))/(Log(Abs(x+y*y)));
            Console.WriteLine(y1);
        }
    }
}
