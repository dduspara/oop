using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;
            double a;
            try
            {
            Console.WriteLine("Unesite broj:");
            broj = int.Parse(Console.ReadLine());
                if (broj > 0)
                {
                    a = Math.Sqrt(broj);
                    Console.WriteLine("Rezultat: {0}", a);
                }
                else
                {
                   Console.WriteLine("Broj mora biti veći od nule");
                }
            }

            catch
            {
                Console.WriteLine("Pogrešan unos.");
            }

            Console.ReadKey();
        }
    }
}
