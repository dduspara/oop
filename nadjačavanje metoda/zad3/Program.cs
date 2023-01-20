using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OsobnoVozilo auto = new OsobnoVozilo("204", "benzin", "5", "5", "siva");
            Kamion kamioncek = new Kamion("450", "dizel", "10", "16t");
            Console.WriteLine("Podaci o autu:");
            Console.WriteLine(auto.GetPodaciOVozilu());
            Console.WriteLine("");
            Console.WriteLine("Podaci o kamionu:");
            Console.WriteLine(kamioncek.GetPodaciOVozilu());


            Console.ReadKey();
        }

        class MotornoVozilo
        {
            public string snaga_motora { get; set; }
            public string vrsta_goriva { get; set; }    

            public MotornoVozilo (string snaga_motora, string vrsta_goriva)
            {
                this.snaga_motora = snaga_motora;
                this.vrsta_goriva = vrsta_goriva;
            }

            public virtual string GetPodaciOVozilu()
            {
                return string.Format("Snaga motora: {0}\nVrsta goriva: {1}", this.snaga_motora, this.vrsta_goriva);
            }

        }
        class OsobnoVozilo : MotornoVozilo
        {
            public string broj_sjedala { get; set; }
            public string broj_vrata { get; set; }
            public string boja_vozila { get; set; }

            public OsobnoVozilo (string snaga_motora, string vrsta_goriva, string broj_sjedala, string broj_vrata, string boja_vozila) : base(snaga_motora, vrsta_goriva)
            {
                this.broj_sjedala = broj_sjedala;
                this.broj_vrata = broj_vrata;
                this.boja_vozila = boja_vozila;
            }
            public override string GetPodaciOVozilu()
            {
                return string.Format("Snaga motora: {0}\nVrsta goriva: {1} \nBroj sjedala: {2} \nBroj vrata: {3} \nBoja vozila: {4}", this.snaga_motora, this.vrsta_goriva, this.broj_sjedala, this.broj_vrata, this.boja_vozila);
            }

        }
        class Kamion : MotornoVozilo
        {
            public string broj_kotaca { get; set; }
            public string max_tezina { get; set; }

            public Kamion (string snaga_motora, string vrsta_goriva, string broj_kotaca, string max_tezina) : base (snaga_motora, vrsta_goriva)
            {
                this.broj_kotaca = broj_kotaca;
                this.max_tezina = max_tezina;
            }

            public override string GetPodaciOVozilu()
            {
                return string.Format("Snaga motora: {0}\nVrsta goriva: {1} \nBroj kotača: {2} \nMax težina: {3}", this.snaga_motora, this.vrsta_goriva, this.broj_kotaca, this.max_tezina);
            }
        }
    }
}
