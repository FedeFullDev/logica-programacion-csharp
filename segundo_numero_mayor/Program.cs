using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace segundo_numero_mayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Dado un listado de números, encuentra el SEGUNDO más grande
            */


            Console.WriteLine("Ingrese los numeros que quiere analizar");

            int x = 0;
            int numero = 0;
            List<int> numeros = new List<int>();
            string terminarBucle = string.Empty;

            while (true)
            {
                Console.WriteLine($"Número {x}:");
                numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);

                Console.WriteLine(" Ingrese \"STOP\" si quiere terminar de cargar números, sino apriete space y continúe");
                terminarBucle = Console.ReadLine();

                if (terminarBucle.Trim().ToUpper().Replace(" ", "") == "STOP")
                {
                    break;
                }

                x++;
            }



            int numMax = numeros[0];
            int segundoNumMax = 0;
            for (x = 0; x < numeros.Count; x++)
            {
                if (numeros[x] > numMax)
                {
                    numMax = numeros[x];
                }
                else if (numeros[x] < numMax)
                {
                    segundoNumMax = numeros[x];
                }
                else if (numeros[x] > segundoNumMax)
                {
                    segundoNumMax = numeros[x];
                }
            }


            Console.WriteLine($"El segundo número más grande de la lista es: {segundoNumMax}");

            Console.ReadKey();



        }
    }
}
