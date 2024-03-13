using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_recursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Escribe una función que calcule y retorne el factorial de un número dado
             * de forma recursiva.
            */



            Console.WriteLine("Ingrese un número");
            int N = int.Parse(Console.ReadLine());


            int factorial = Factorial(N);

            if (factorial > 0)
            {
                Console.WriteLine($"El Factorial de {N} es: {factorial}");
            }else if(factorial == 0)
            {
                Console.WriteLine("Por definición matemática, no existe el factorial de un número negativo");
            }


            Console.ReadKey();

        }


        static int Factorial(int numero)
        {
           if (numero >= 0)
            {
                if (numero == 1 || numero == 0)
                {
                    return 1;
                }


                return numero * Factorial(numero - 1);
            }


            return 0;
           
        }
    }
}
