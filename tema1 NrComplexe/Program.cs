using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1_NrComplexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(3, -4);
            Complex c3 = new Complex(3);
            Complex c4 = new Complex(0, -5);
            Complex c5 = new Complex("5-6i");
            Complex c6 = new Complex(0, 0);


            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);


            // TODO: supraincarcarea operatorilor aritmetici pentru tipul Complex
            //complex suma =c1+c2;
            //DONE
             Complex adunare = c1 + c2;
            Console.WriteLine($"Suma lui {c1} si {c2} este {adunare}");
            Complex scadere = c1 - c2;
            Console.WriteLine($"Diferenta lui {c1} si {c2} este {scadere}");
            Complex inmultire = c1 * c2;
            Console.WriteLine($"Produsul lui {c1} si {c2} este {inmultire}");
            
            Complex suma = c1.Add(c2);

            Console.WriteLine($"{c1} + {c2} = {suma}");


            Complex diff = c1.Subtract(c2);
            Console.WriteLine($"{c1} - {c2} = {diff}");

            Complex mult = c1.Multiply(c2);
            Console.WriteLine($"{c1} * {c2} = {mult}");
            double rezultat=c2.Modul(c2);
            Console.WriteLine($"Modulul lui {c2} este {rezultat}");
            double unghi = c2.Argument(c2);
            Console.WriteLine($"Argumentul lui {c2} este {unghi}");

            Console.ReadKey();
        }
    }
}
