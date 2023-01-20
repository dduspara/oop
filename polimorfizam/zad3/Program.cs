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
            KucniLjubimac pes = new KucniLjubimac(15, "crni", "mjesanac", "johnny", "johnnyić");
            KucniLjubimac pes2 = new KucniLjubimac(12, "bijeli", "pitbull", "ivo", "ivic");
            KucniLjubimac pes3 = new KucniLjubimac(14, "plavi", "rotvajler", "ana", "anic");

            List <KucniLjubimac> peseki = new List<KucniLjubimac> ();
            peseki.Add (pes);
            peseki.Add (pes2);  
            peseki.Add (pes3);

            foreach (KucniLjubimac i in peseki)
            
            {
                Console.WriteLine("Težina: {0}, Klasa: {1}",i.tezina, i);
                Console.WriteLine("Boja: {0}, Klasa: {1}", i.boja, i);
                Console.WriteLine("Pasmina: {0}, Klasa: {1}", i.pasmina, i);
                Console.WriteLine("Ime: {0}, Klasa: {1}", i.ime_vlasnika, i);
                Console.WriteLine("Prezime: {0}, Klasa: {1}", i.prezime_vlasnika, i);
                Console.WriteLine("");
            }
            Console.ReadKey();

        }

        class Pas
        {
            public int tezina { get; set; }

            public string boja { get; set; }
            public string pasmina { get; set; } 

            public Pas (int tezina, string boja, string pasmina)
            {
                this.tezina = tezina;
                this.boja = boja;
                this.pasmina = pasmina;
            }
        }
        class KucniLjubimac : Pas
        {
            public string ime_vlasnika { get; set; }
            public string prezime_vlasnika { get; set; }

            public KucniLjubimac(int tezina, string boja, string pasmina, string ime_vlasnika, string prezime_vlasnika) : base(tezina, boja, pasmina)
            {
                this.ime_vlasnika = ime_vlasnika;
                this.prezime_vlasnika = prezime_vlasnika;
            }
        }
    }
}
