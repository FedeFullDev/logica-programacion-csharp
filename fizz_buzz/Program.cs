using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz_buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribe un programa que muestre por consola (con un print) los
             * números de 1 a 100 (ambos incluidos y con un salto de línea entre
             * cada impresión), sustituyendo los siguientes:
             * - Múltiplos de 3 por la palabra "fizz". 
             * - Múltiplos de 5 por la palabra "buzz".
             * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
            */


           
            

            for (int x = 1; x <= 100; x++)
            {
                bool divisiblePorTres = x % 3 == 0;
                bool divisiblePorCinco = x % 5 == 0;

                if (divisiblePorTres && divisiblePorCinco)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (divisiblePorTres)
                {
                    Console.WriteLine("fizz");
                }
                else if (divisiblePorCinco)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }



            Console.ReadKey();
        }
    }
}
