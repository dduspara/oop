using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FiksniTelefon fiksni = new FiksniTelefon("Dominik", "Duspara", "12312424");
            MobilniTelefon mobilni = new MobilniTelefon("Ivo", "Ivic", "21414124");
            

            Console.WriteLine("Ime: {0}\n Prezime: {1}\n Broj: {2}",fiksni.ime, fiksni.prezime, fiksni.broj);
            Console.WriteLine(fiksni.GetVrstaTelefona());
            Console.WriteLine("");
            Console.WriteLine("Ime: {0}\n Prezime: {1}\n Broj: {2}", mobilni.ime, mobilni.prezime, mobilni.broj);
            Console.WriteLine(mobilni.GetVrstaTelefona());


            Console.ReadKey();
        }
        class FiksniTelefon
        {
            public string ime { get; set; }
            public string prezime { get; set; }
            public string broj { get; set; }

            public FiksniTelefon (string ime, string prezime, string broj)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.broj = broj;
            }

            public virtual string GetVrstaTelefona()
            {
                return "Ovo je fiksni broj telefona.";
            }
        }

        class MobilniTelefon : FiksniTelefon
        {
            public MobilniTelefon (string ime, string prezime, string broj) : base (ime, prezime, broj)
            {

            }
            public override string GetVrstaTelefona()
            {
                return "Ovo je mobilni broj telefona.";
            }
        }
    }
}
