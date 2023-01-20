using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3___iznimke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            char operacija;

            try
            {
                Console.WriteLine("Unesite prvi broj:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesite matematičku operaciju:");
                operacija = char.Parse(Console.ReadLine());

                switch (operacija)
                {
                    case '+':
                        Console.WriteLine(a + b);
                        break;
                    case '-':
                        Console.WriteLine(a - b);
                        break;
                    case '*':
                        Console.WriteLine(a * b);
                        break;
                    case '/':
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine("Krivi unos.");
                        break;
                }


            }

            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Krivi unos.");
            }

            Console.ReadKey();
        }
    }
}
