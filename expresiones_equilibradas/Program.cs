using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expresiones_equilibradas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Crea una función que reciba dos cadenas como parámetro (str1, str2)
              * e imprima otras dos cadenas como salida (out1, out2).
              * - out1 contendrá todos los caracteres presentes en la str1 pero NO
              *   estén presentes en str2.
              * - out2 contendrá todos los caracteres presentes en la str2 pero NO
              *   estén presentes en str1.
            */


            Console.WriteLine("Ingrese la palabra 1");
            string palabra1 = Console.ReadLine();
            Console.WriteLine("Ingrese la palabra 2");
            string palabra2 = Console.ReadLine();

            (string salida1, string salida2) = Funcion(palabra1, palabra2);

            Console.Write("Palabra 1 antes del cambio: " + palabra1 +  "\n");
            Console.WriteLine("Palabra 1: " + salida1);
            Console.Write("Palabra 2 antes del cambio: " + palabra2 +  "\n");
            Console.WriteLine("Palabra 2: " + salida2);

            Console.ReadKey();
        }

        static (string, string) Funcion(string cadena1, string cadena2)
        {
          
            string resultado1 = string.Empty;
            string resultado2 = string.Empty;

            foreach (char caracter in cadena1)
            {
                if (!cadena2.Contains(caracter))
                {
                    resultado1 += caracter;
                }
            }

            foreach (char caracter in cadena2)
            {
                if (!cadena1.Contains(caracter))
                {
                    resultado2 += caracter;
                }
            }

            return (resultado1, resultado2);
        }
    }
}
