using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_mayuscula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              * Crea una función que reciba un String de cualquier tipo y se encargue de
              * poner en mayúscula la primera letra de cada palabra.
              * - No se pueden utilizar operaciones del lenguaje que
              *   lo resuelvan directamente.
            */

            Console.WriteLine("Igrese una palabra");
            string palabra = Console.ReadLine();

             convertToMajuscule(ref palabra);

            Console.WriteLine("La palabra convertida a mayúscula es: " + palabra);


            Console.ReadKey();
            /*
            Utilizo el mismo nombre para la variable, en este caso palabra, tanto para el parámetro de la función
            como también para el argumento.Pero eso se permite debido al Scope.

            */
        }

        static void convertToMajuscule( ref string palabra)
        {

            string palabraConvertida = string.Empty;
            foreach (char letra in palabra)
            {

                char letraCovertida = Char.ToUpper(letra);
               palabraConvertida += letraCovertida;
            }

            palabra = palabraConvertida;


        }
    }
}
