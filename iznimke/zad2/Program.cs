using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            try
            {
                Console.WriteLine("Unesite prvi broj:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite treci broj:");
                c = int.Parse(Console.ReadLine());
                int rezultat = a + b + c;
                Console.WriteLine("Zbroj iznosi: {0}", rezultat);
            }

            catch (FormatException)
            {
                Console.WriteLine("Pogrešan unos.");
            }
            Console.ReadKey();
        }
    }
}
