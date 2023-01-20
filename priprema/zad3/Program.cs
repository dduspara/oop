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
            NeradniDan dan = new NeradniDan(new DateTime(2023, 12, 25), "Neradni dan");
            Blagdan blagdan = new Blagdan(new DateTime(2023, 12, 25), "Blagdan", "Božić");
            Console.WriteLine("Neradni dan:");
            Console.WriteLine("Datum: {0}", dan.datum.ToShortDateString());
            Console.WriteLine("Opis: {0}", dan.opis);
            Console.WriteLine("");
            Console.WriteLine("Blagdan:");
            Console.WriteLine("Datum: {0}", blagdan.datum.ToShortDateString());
            Console.WriteLine("Opis: {0}", blagdan.opis);
            Console.WriteLine("Naziv: {0}", blagdan.naziv);


            Console.ReadKey();
        }
        class NeradniDan
        {
            public DateTime datum { get; set; }
            public string opis {get; set; }

            public NeradniDan()
            {

            }

            public NeradniDan (DateTime datum, string opis)
            {
                this.datum = datum;
                this.opis = opis;
            }


        }
        class Blagdan : NeradniDan
        {
            public string naziv {get; set; }

            public Blagdan ()
            {

            }
            public Blagdan (DateTime datum, string opis, string naziv) : base(datum, opis)
            {
                this.naziv = naziv;
            }

        }

    }
}
