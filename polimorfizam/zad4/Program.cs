using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pice sok = new Pice("Koka kola", "1.5l", "tamna");
            AlkoholnoPice zestica = new AlkoholnoPice("Pelin", "0,7l", "smeđa", "31%");
            List <Pice> pića = new List<Pice>();
            pića.Add(sok);
            pića.Add(zestica);

            foreach (var i in pića) 
            {

                
                    Console.WriteLine("Naziv pića: {0}", i.naziv_pica);
                    Console.WriteLine("Pakiranje: {0}", i.velicina_pakovanja);
                    Console.WriteLine("Boja: {0}", i.boja);
                    Console.WriteLine("Klasa: {0}", i.GetType());
                    Console.WriteLine("");
                
                
            }

            Console.ReadKey();
        }
        class Pice
        {
            public string naziv_pica { get; set; }
            public string velicina_pakovanja { get; set; }
            public string boja { get; set; }
            public string cijena { get; set; }

            public Pice (string naziv_pica, string velicina_pakovanja, string boja)
            {
                this.naziv_pica = naziv_pica;
                this.velicina_pakovanja = velicina_pakovanja;
                this.boja = boja;
            }
        }
        class AlkoholnoPice : Pice
        {
            public string postotak_alkohola { get; set; }

            public AlkoholnoPice (string naziv_pica, string velicina_pakovanja, string boja, string postotak_alkohola) : base (naziv_pica, velicina_pakovanja, boja)
            {
                this.postotak_alkohola = postotak_alkohola;
            }
        }
    }
}
