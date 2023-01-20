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
            Proizvod prvi = new Proizvod("Televizor", 3999);
            Hrana drugi = new Hrana("Kruh", 12);

            Console.WriteLine("Naziv: {0}, Cijena: {1}",prvi.naziv, prvi.cijena_bez_pdv);
            Console.WriteLine("PDV je: {0}", prvi.GetPDV());
            Console.WriteLine("");
            Console.WriteLine("Naziv: {0}, Cijena: {1}", drugi.naziv, drugi.cijena_bez_pdv);
            Console.WriteLine("PDV je: {0}", drugi.GetPDV());

            Console.ReadKey();
        }
        class Proizvod
        {
            public string naziv { get; set; }
            public int cijena_bez_pdv { get; set; }
            public int pdv = 25;

            public Proizvod (string naziv, int cijena_bez_pdv)
            {
                this.naziv = naziv;
                this.cijena_bez_pdv = cijena_bez_pdv;
            }

            public virtual int GetPDV()
            {
                return pdv;   
            }
        }

        class Hrana : Proizvod
        {
            public Hrana(string naziv, int cijena_bez_pdv) : base(naziv, cijena_bez_pdv)
            {

            }
            public override int GetPDV()
            {
                return pdv = 13;
            }
        }
    }
}
