using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_narcisista
{
    internal class Program
    {
  

        static void Main(string[] args)
        {
            /*
              * Escribe una función que calcule si un número dado es un número de Armstrong
              * (o también llamado narcisista).
              * Si no conoces qué es un número de Armstrong, debes buscar información
              * al respecto.
            */


            bool validarEntrada;

            Console.WriteLine("Ingrese un número de tres digitos o el número 1");
            int N = int.Parse(Console.ReadLine());

            if (N == 1 || (N >= 100 && N < 1000))
            {
                validarEntrada = true;

                if (ValidarNum(N))
                {
                    Console.WriteLine("Es un número narcisista");
                }
                else
                {
                    Console.WriteLine("No es un número narcisista");
                }
            }
            else
            {
                validarEntrada = false;

                while (!validarEntrada)
                {
                    Console.WriteLine("Ingrese un número valido. Es decir, 1 o un número de 3 dígitos.");
                    N = int.Parse(Console.ReadLine());

                    if (N == 1 || (N >= 100 && N < 1000))
                    {
                        validarEntrada = true;
                    }

                }

                if (validarEntrada)
                {
                    if (ValidarNum(N))
                    {
                        Console.WriteLine("Es un número narcisista");
                    }
                    else
                    {
                        Console.WriteLine("No es un número narcisista");
                    }
                }
            }




            Console.ReadKey();
        }

        static bool ValidarNum(int numero)
        {
           


            int NumeroSinModificar = numero;

            int A, B, C, resultado;

            if (numero == 1)
            {
                resultado = 1;
            }


            
            int cantidadDigitos = 0;

            A = numero % 10;

            cantidadDigitos++;

            numero = numero / 10;

            B = numero % 10;

            cantidadDigitos++;

            numero = numero / 10;

            C = numero;

            cantidadDigitos++;


            resultado = (int)Math.Pow(A, cantidadDigitos) + (int)Math.Pow(B, cantidadDigitos) + (int)Math.Pow(C, cantidadDigitos);


            if (resultado == NumeroSinModificar)
            {
                return true;
            }else
            {
                return false;
            }

      

        }
    }
}
