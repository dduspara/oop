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
            KreditnaKartica kartica = new KreditnaKartica("Dominik", "Duspara", 12313, "Visa", 10000);

            Console.WriteLine("Ime: {0}", kartica.ime);
            Console.WriteLine("Prezime: {0}", kartica.prezime);
            Console.WriteLine("Broj kartice: {0}", kartica.broj);
            Console.WriteLine("Karticu izdao: {0}", kartica.naziv_tvrtke);
            Console.WriteLine("Limit: {0}", kartica.limit);

            Console.ReadKey();
        }

        class KreditnaKartica
        {
            public string ime {get; set; }
            public string prezime {get; set; }
            public int broj {get; set; }
            public string naziv_tvrtke {get; set; }
            public int limit {get; set; }

            public KreditnaKartica ()
            {

            }

            public KreditnaKartica (string ime, string prezime, int broj, string naziv_tvrtke, int limit)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.broj = broj;
                this.naziv_tvrtke = naziv_tvrtke;
                this.limit = limit;
            }
        }
    }
}
