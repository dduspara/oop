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
            List<int> brojevi = new List<int>();

            brojevi.Add(2);
            brojevi.Add(21);   
            brojevi.Add(23);   
            brojevi.Add(35);
            brojevi.Add(77);
            brojevi.Add(76);

            Console.WriteLine("Najveći broj je: {0}", najveci(brojevi));
            Console.WriteLine("Najmanji broj je: {0}", najmanji(brojevi));
            Console.WriteLine("Aritmetička sredina iznosi: {0}",arit(brojevi));

            Console.ReadKey();
        }
        private static int najveci (List <int> lista)
        {
            int najveciBroj = lista.Max();
            return najveciBroj;
        }

        private static int najmanji(List<int> lista)
        {
            int najmanjiBroj = lista.Min();
            return najmanjiBroj;
        }

        private static int arit(List<int> lista)
        {
            int broj = lista.Count();
            int zbroj = lista.Sum();
            int ar = zbroj / broj;
            return ar;
        }
    }
}
