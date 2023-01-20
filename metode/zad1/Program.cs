using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unos;
            Console.WriteLine("Unesi cijeli pozitivni broj:");
            unos = int.Parse(Console.ReadLine());
            if (unos < 0) 
            {
                Console.WriteLine("Broj mora biti pozitivan.");
            }
            else
            {
                Console.WriteLine(znamenke(unos));
            }
            Console.ReadKey();
        }

        private static int znamenke (int a)
        {
            int ostatak = 0;
            int obrnuto = 0;
            while (a > 0)
            {
                ostatak = a % 10;
                obrnuto = (obrnuto * 10) + ostatak;
                a = a / 10;
            }
            return obrnuto;
            


        }
        
    }
}
