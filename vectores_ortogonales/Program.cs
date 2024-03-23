using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectores_ortogonales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Crea un programa que determine si dos vectores son ortogonales.
              * - Los dos array deben tener la misma longitud.
              * - Cada vector se podría representar como un array. Ejemplo: [1, -2]
            */



            Console.WriteLine("Ingrese la cantidad de componentes que quiere agregar a los vectores");
            int N = int.Parse(Console.ReadLine());
            int[] vector1 = new int[N];
            int[] vector2 = new int[N];

            int x;

            Console.Write("Cargando el primer vector \n");
            for (x = 0; x < N; x++)
            {
                Console.WriteLine($"Ingrese el número {x}");

                vector1[x] = int.Parse(Console.ReadLine());
            }



            Console.Write("Cargando el segundo vector \n");
            for (x = 0; x < N; x++)
            {
                Console.WriteLine($"Ingrese el número {x}");

                vector2[x] = int.Parse(Console.ReadLine());
            }


            int Acumulador = 0;

            for (x = 0; x < N; x++)
            {
                Acumulador += vector1[x] * vector2[x];


            }

            if (Acumulador == 0)
            {
                Console.WriteLine("Los vectores son ortogonales");
                /*
                Esto  porque dos vectores son ortogonales cuando su producto escalar es igual a 0, que es lo mismo también que decir que son
                ortogonales  cuando forman un ángulo de 90 grados.
                */
            }


            Console.ReadKey();
        }
    }
}
