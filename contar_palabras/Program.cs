using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace contar_palabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               * Crea un programa que cuente cuantas veces se repite cada palabra
               * y que muestre el recuento final de todas ellas.
               * - Los signos de puntuación no forman parte de la palabra.
               * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
               * - No se pueden utilizar funciones propias del lenguaje que
               *   lo resuelvan automáticamente.
            */



            Console.WriteLine("Ingrese la cantidad de palabras que quiere utilizar");

            bool validar = int.TryParse(Console.ReadLine(), out int resultado);

            int cantidad = validar ? resultado : 0;


           
         
            string palabra;
            List<string> listPalabrass = new List<string>();
            List<int> listContadorPalabrasRepetidas = new List<int>();

            
           
            
                int[] contadorDePalabras = new int[cantidad];

                int y = 0;
                while (y < cantidad)
                {
                    contadorDePalabras[y] = 0;

                    y++;
                }



            int contadorPalabrasRepetidas = 0;
            int x = 0;
            while (x < cantidad && cantidad != 0)
            {

                Console.WriteLine($"Ingrese la palabra {x + 1} ");
                palabra = Console.ReadLine().ToLower();

                if (x == 0)
                {
                    listPalabrass.Add(palabra);
                    contadorDePalabras[x] = contadorPalabrasRepetidas++;
                    listContadorPalabrasRepetidas.Add(contadorDePalabras[x]);
                }
                else if (x > 0)
                {
                    int i = 0;
                    contadorPalabrasRepetidas = 0;

                    //este ciclo while es para analizar si las palabras se repiten. Así cada índice tendrá una palabra distinta.

                    while (i < listPalabrass.Count)
                    {
                        if (palabra != listPalabrass[i])
                        {
                            /*
                            agregar a listPalabrass en indice x en lugar del indice i es muy importante. Esto porque si lo agrego en 
                            indice i, corro el riesgo de que se reasigne un valor a un indice que ya tenía ua palabra dentro.
                            */
                            listPalabrass.Add(palabra);

                            if (i == (listPalabrass.Count - 1))
                            {
                                contadorDePalabras[x] += contadorPalabrasRepetidas++;
                                listContadorPalabrasRepetidas.Add(contadorDePalabras[x]);
                            }

                        }



                        if (palabra == listPalabrass[i])
                        {
                            contadorPalabrasRepetidas = 0;
                            if (i == (listPalabrass.Count - 1))
                            {
                                contadorDePalabras[x] = contadorPalabrasRepetidas++;
                                listContadorPalabrasRepetidas[i] += contadorDePalabras[x];

                            }


                        }

                        i++;
                    }




                }




                x++;
            }

            // reutilizo la variable x del ciclo while anterior, ya que no debo usarla más, esto sserá para mostrar las listas.
            // Así también ahorro memoria al no tener que declarar variables nuevas, y queda más limpio el código


           

            for (x = 0; x < listPalabrass.Count; x++)
            {
                Console.WriteLine($"La palabra {listPalabrass[x]} fue escrita {listContadorPalabrasRepetidas[x]} veces");
            }

            Console.ReadKey();
        }
    }
}
