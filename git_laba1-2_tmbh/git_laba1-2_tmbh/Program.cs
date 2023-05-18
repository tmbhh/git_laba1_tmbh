using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace git_laba1_2_tmbh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("L=");
            double l = Convert.ToDouble(Console.ReadLine());
            double r =l/(2*PI);
            Console.WriteLine("r=", r);
            double s =PI*Pow(r,2);
            Console.WriteLine("s=",s);
            
        }
    }
}
