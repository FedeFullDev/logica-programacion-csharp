 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palabra_palindroma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Escribe una función que reciba un texto y retorne verdadero o
              * falso (Boolean) según sean o no palíndromos.
              * Un Palíndromo es una palabra o expresión que es igual si se lee
              * de izquierda a derecha que de derecha a izquierda.
              * NO se tienen en cuenta los espacios, signos de puntuación y tildes.
              * Ejemplo: Ana lleva al oso la avellana.
            */

            Console.WriteLine("Ingrese un texto");
            string texto = Console.ReadLine();

            if (Polindromo(texto))
            {
                Console.WriteLine($"El texto  \" {texto} \" es un políndromo");
            }
            else
            {
                Console.WriteLine($"El texto \" {texto} \" no es un políndromo");
            }

            Console.ReadKey();
            
        }


        static bool Polindromo(string texto)
        {

            texto = texto.Trim().Replace(" ", "");

            char[] cadena = texto.ToCharArray();
             
            
            Array.Reverse(cadena);


            string textoInvertido = new string(cadena);
            
            if (texto.ToLower() == textoInvertido.ToLower())
            {
                return true;
            }else
            {
                return false;
            }

           
        }
    }
}
