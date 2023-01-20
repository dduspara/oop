using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();
            while (brojevi.Count() < 10)
            {
                int unos;
                Console.WriteLine("Unesi broj:");
                unos = int.Parse(Console.ReadLine()); 
                brojevi.Add(unos);  
            }
            if (brojevi.Count() == 10)
            {
                rezultat(znamenke(brojevi), sedmice(brojevi));
            }
            Console.ReadKey();
        }
        private static int znamenke(List<int> brojevi)
        {
            List<int> lista = new List<int>();

            int brojac = 0;

            for (int i = 0; i < brojevi.Count; i++)
            {
                if ((brojevi[i] > 9 && brojevi[i] < 100) || (brojevi[i] > 99 && brojevi[i] < 1000) || ((brojevi[i] < -9 && brojevi[i] > -100) || (brojevi[i] < -99 && brojevi[i] > -1000)))
                {
                    brojac++;
                }
            }
            return brojac;
        }

        private static int sedmice(List<int> brojevi)
        {
            List<int> lista = new List<int>();
            int brojac = 0;
            for (int i = 0; i < brojevi.Count; i++)
            {
                if (((brojevi[i] % 10 == 7)))
                {
                    brojac++;
                }
            }
            return brojac;
        }
        private static void rezultat(int rezultat1, int rezultat2)
        {
            Console.WriteLine(rezultat1);
            Console.WriteLine(rezultat2);
        }
        


    }
}
