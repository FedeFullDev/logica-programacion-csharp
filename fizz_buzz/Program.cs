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


            string xSustituido;
            int xNoMultiplo = 0;
            int contador = 0;
            bool validarMultiplo;

            for (int x = 1; x <= 100; x++)
            {


                for (int y = 0; y < 100; y++)
                {
                    if (x == 3 * (y + 1))
                    {
                        xSustituido = "fizz";
                        Console.WriteLine($"número{x} es: {xSustituido} porque es múltiplo de 3 ");
                        //true porque dentro de los 100 numeros que deben evaluarse, es posible que x lo sea si entró
                        // una vez al ciclo.No sabemos que pasará con los demás números, pero a priori consideramos
                        // que hay una posibilidad
                        validarMultiplo = true;

                        if (validarMultiplo)
                            xNoMultiplo = 0;


                    }
                    else
                    {
                        validarMultiplo = false;

                        if (!validarMultiplo)
                        {
                            /*
                            Ahora x no fué múltiplo para uno de los valores, por lo que aumentan las posibilidades de que
                            no sea múltiplo
                            */
                            xNoMultiplo = x;
                        }

                    }



                    if (x == 5 * (y + 1))
                    {
                        xSustituido = "buzz";
                        Console.WriteLine($"número{x} es: {xSustituido} porque es múltiplo de 5 ");
                        validarMultiplo = true;

                        if (validarMultiplo)
                            xNoMultiplo = 0;

                    }
                    else
                    {
                        validarMultiplo = false;

                        if (!validarMultiplo)
                        {

                            xNoMultiplo = x;
                        }
                    }


                    if (x == 15 * (y + 1))
                    {
                        xSustituido = "fizzbuzz";
                        Console.WriteLine($"número{x} es: {xSustituido} porque es múltiplo de 3 y 5 ");
                        validarMultiplo = true;

                        if (validarMultiplo)
                            xNoMultiplo = 0;
                    }
                    else
                    {
                        validarMultiplo = false;

                        if (!validarMultiplo)
                        {

                            xNoMultiplo = x;
                        }
                    }

                    contador++;

                    if (xNoMultiplo != 0 && contador == 100)
                    {
                        Console.WriteLine(x);
                    }

                }










            }

            Console.ReadKey();
        }
    }
}
