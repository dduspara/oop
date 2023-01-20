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
            Student student = new Student("Dominik", "Duspara", "12141244", "VVG", "ORS", new DateTime(2019, 07, 15));
            DiplomiraniStudent diplomiraniStudent = new DiplomiraniStudent("Ana", "Anic", "12421421412", "VVG", "IS", new DateTime(2019, 07, 15), new DateTime(2024,09,15));
            List<Student> students = new List<Student>();
            students.Add(student);
            students.Add(diplomiraniStudent);


            foreach (var s in students)
            {
                Console.WriteLine(s.PodaciOStudentu());
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        class Student
        {
            public string ime { get; set; }
            public string prezime { get; set; }
            public string jmbag { get; set; }
            public string ustanova { get; set; }
            public string studij { get; set; }
            public DateTime datum_upisa { get; set; }

            public Student() { }

            public Student(string ime, string prezime, string jmbag, string ustanova, string studij, DateTime datum_upisa)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.jmbag = jmbag;
                this.ustanova = ustanova;
                this.studij = studij;
                this.datum_upisa = datum_upisa;
            }

            public virtual string PodaciOStudentu()
            {
                return string.Format("Ime: {0}\nPrezime: {1}\nJMBAG: {2}\nUstanova: {3}\nStudij: {4}\nDatum upisa: {5}", this.ime,this.prezime,
                    this.jmbag, this.ustanova, this.studij, this.datum_upisa.ToShortDateString());
            }
        }
        class DiplomiraniStudent : Student
        {
            public DateTime datum_zavrsetka { get; set; }

            public DiplomiraniStudent () { }
            public DiplomiraniStudent(string ime, string prezime, string jmbag, string ustanova, string studij, DateTime datum_upisa, DateTime datum_zavrsetka) : base(ime, prezime, jmbag, ustanova, studij, datum_upisa)
            {
                this.datum_zavrsetka = datum_zavrsetka;
            }
            public override string PodaciOStudentu()
            {
                return string.Format("Ime: {0}\nPrezime: {1}\nJMBAG: {2}\nUstanova: {3}\nStudij: {4}\nDatum upisa: {5}\nDatum završetka: {6}", this.ime, this.prezime,
                    this.jmbag, this.ustanova, this.studij, this.datum_upisa.ToShortDateString(), this.datum_zavrsetka.ToShortDateString());
            }

        }



    }
}
