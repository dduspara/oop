using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OsobnoVozilo osobnoVozilo = new OsobnoVozilo("200ks", "benzin", "5", "5", "plava");
            Kamion kamion = new Kamion("450ks", "dizel", "6", "12,5t");
            List<MotornoVozilo> list = new List<MotornoVozilo>();
            list.Add(osobnoVozilo);
            list.Add(kamion);

            foreach (MotornoVozilo i in list)
            {
                if (i.GetType() == typeof(OsobnoVozilo))
                {
                    Console.WriteLine("Snaga: {0}, Klasa: {1}", i.snaga_motora, i);
                    Console.WriteLine("Gorivo: {0}, Klasa: {1}", i.vrsta_goriva, i);
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Snaga: {0}, Klasa: {1}", i.snaga_motora, i);
                    Console.WriteLine("Gorivo: {0}, Klasa: {1}", i.vrsta_goriva, i);
                }
            }
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
        }
        class OsobnoVozilo : MotornoVozilo
        {
            public string broj_sjedala { get; set; }
            public string broj_vrata { get; set; }  
            public string boja_vozila { get; set; } 

            public OsobnoVozilo(string snaga_motora, string vrsta_goriva,string broj_sjedala, string broj_vrata, string boja_vozila) : base(snaga_motora, vrsta_goriva) 
            {
                this.broj_sjedala = broj_sjedala;
                this.broj_vrata = broj_vrata;
                this.boja_vozila = boja_vozila;
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
        }
    }
}
