using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace anagrama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
               * Escribe una función que reciba dos palabras (String) y retorne
               * verdadero o falso (Bool) según sean o no anagramas.
               * - Un Anagrama consiste en formar una palabra reordenando TODAS
               *   las letras de otra palabra inicial.
               * - NO hace falta comprobar que ambas palabras existan.
               * - Dos palabras exactamente iguales no son anagrama.
            */




            if (EsAnagrama("ramita", "tarima"))
            {
                Console.WriteLine("Es anagrama");
            }
          else
            {
                Console.WriteLine("No es anagrama");
            }






            Console.ReadKey();
        }

        static bool EsAnagrama(string palabra1, string palabra2)
        {
          

            if (palabra1 != palabra2)
            {
               string palabraToLower = palabra1.ToLower();
                string palabra2ToLower = palabra2.ToLower();



                char[] Palabra1Vector = palabraToLower.ToCharArray();
                Array.Sort(Palabra1Vector);
                string resultado = new string(Palabra1Vector);

                char[] Palabra2Vector2 = palabra2ToLower.ToCharArray();
                Array.Sort(Palabra2Vector2);
                string resultado2 = new string(Palabra2Vector2);

                if (resultado == resultado2)
                {
                    return true;
                }
            }






            return false;





        }



    }
}
