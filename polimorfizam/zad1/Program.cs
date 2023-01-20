using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Dominik", "Duspara", "1221425232");
            Student student = new Student("Ana", "Anic", "231241412412", "13123288", "IS", "4");

            List <Osoba> lista = new List<Osoba>();
            
            lista.Add(osoba);
            lista.Add(student);

            foreach (Osoba a in lista)
            {
                if (a.GetType() == typeof(Osoba))
                {
                    Console.WriteLine("Ime: {0}, Klasa: {1}", a.ime, a);
                    Console.WriteLine("Prezime: {0}, Klasa: {1}", a.prezime, a);
                    Console.WriteLine("OIB: {0}, Klasa: {1}", a.prezime, a);
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Ime: {0}, Klasa: {1}", a.ime, a);
                    Console.WriteLine("Prezime: {0}, Klasa: {1}", a.prezime, a);
                    Console.WriteLine("OIB: {0}, Klasa: {1}", a.prezime, a);
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
    }
    class Osoba
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string OIB { get; set; }

        public Osoba(string ime, string prezime, string OIB)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.OIB = OIB;
        }

    }

    class Student:Osoba
    {
        public string JMBAG { get; set; }
        public string naziv_studija { get; set; }  
        public string nastavna_godina {get; set; }

        public Student (string ime, string prezime, string OIB, string JMBAG, string naziv_studija, string nastavna_godina) : base (ime, prezime, OIB)  
        {
            this.JMBAG = JMBAG;
            this.naziv_studija = naziv_studija;
            this.nastavna_godina = nastavna_godina;
        }

    }

}
