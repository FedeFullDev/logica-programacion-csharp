using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace num_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Escribe un programa que se encargue de comprobar si un número es o no primo.
              * Hecho esto, imprime los números primos entre 1 y 100.
            */

            int contador;

            for (int x = 1; x <= 100; x++)
            {
                contador = 0;

                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine(x);
                }else
                {
                    Console.WriteLine($"{x} no es primo");
                }
            }

            Console.ReadKey();
        }
    }
}
