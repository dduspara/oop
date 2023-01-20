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
            Artikl artikl = new Artikl("Kava", 5);
            Console.WriteLine("Naziv: {0}", artikl.naziv );
            Console.WriteLine("Kolicina: {0}", artikl.kolicina);

            Console.ReadKey();
        }

        class Artikl
        {
            public string naziv { get; set; }
            public int kolicina { get; set; }

            public Artikl (string naziv, int kolicina)
            {
                this.naziv = naziv;
                this.kolicina = kolicina;
            }
            public Artikl()
            {

            }


        }

    }
}
