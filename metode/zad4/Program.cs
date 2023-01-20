using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> lista = unosBrojeva();
            Console.WriteLine("Aritmetička sredina iznosi: {0}", arit(lista));

            Console.ReadKey();
        }
        private static List<double> unosBrojeva()
        {
            List<double> brojevi = new List<double>();

            brojevi.Add(1.1);
            brojevi.Add(8.8);
            brojevi.Add(22.10);
            brojevi.Add(19.9);

            return brojevi;
        }
        private static double arit(List<double> brojevi)
        {
            int broj = brojevi.Count();
            double zbroj = brojevi.Sum();
            double ar = zbroj / broj;

            return ar;
        }
    }
}
