using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi polumjer kružnice:");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Površina iznosi: {0}", povKru(r));

            Console.ReadKey();
        }
        private static double povKru(double r)
        {
            double p = r * r * Math.PI;

            if (r <= 0)
            {
                return -1;
            }
            else
            {
                return p;
            }
            
        }
    }
}
