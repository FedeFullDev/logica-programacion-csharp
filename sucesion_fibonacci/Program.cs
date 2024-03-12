using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucesion_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Escribe un programa que imprima los 50 primeros números de la sucesión
              * de Fibonacci empezando en 0.
              * - La serie Fibonacci se compone por una sucesión de números en
              *   la que el siguiente siempre es la suma de los dos anteriores.
              *   0, 1, 1, 2, 3, 5, 8, 13...
            */


            int x = 0;
            int y = 1;
            int z = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(z);
                
                    x = y;
                    y = z;
                    z = x + y;

              
            }


            Console.ReadKey();

        }


        // usaré una función recursiva


      
    }
}
