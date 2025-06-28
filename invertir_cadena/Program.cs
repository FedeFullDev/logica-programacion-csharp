using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace invertir_cadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Crea un programa que invierta el orden de una cadena de texto
              * sin usar funciones propias del lenguaje que lo hagan de forma automática.
              * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
            */

            Console.Write(InvertirCadena("Amor"));

            Console.Write(InvertirCadenaManualmente("Palo"));



            Console.ReadKey();
        }



        static string InvertirCadena(string palabra)
        {
            palabra = palabra.ToLower();

            char[] cadena = palabra.ToCharArray();
            Array.Reverse(cadena);
            String cadenaInvertida = new string(cadena);
            return cadenaInvertida;
           
          
        }

        static char[] InvertirCadenaManualmente(string palabra)
        {
            palabra = palabra.ToUpper();

            char[] cadena = palabra.ToCharArray();

            int contador = cadena.Length - 1;
            char x;
            for (int i = 0; i <= contador; i++)
            {
                

                x = cadena[i];

                cadena[i] = cadena[contador];
                cadena[contador] = x;

                 contador--;
            }
            return cadena;
        }

           
      






    }


}

