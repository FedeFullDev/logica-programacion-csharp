using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Crea una función que reciba dos listas, un booleano y retorne una lista;
              * - Si el booleano es verdadero buscará y retornará los elementos comunes
              *   de las dos listas.
              * - Si el booleano es falso buscará y retornará la cantidad de elementos total entre las dos listas.
              * - No se pueden utilizar operaciones del lenguaje que
              *   lo resuelvan directamente.
            */



            int x = 0;

            string validarCargaNombresApellidos;
            List<string> ListaNombres = new List<string>();
            List<string> ListaApellidos = new List<string>();

            while (x >= 0)
            {
                Console.WriteLine("Ingrese un nombre");
                ListaNombres.Add(Console.ReadLine());

                x++;


                //No se generará un ciclo infinito ya que a instrucción if siguiente lo detiene.

                if (x > 0)
                {
                    Console.WriteLine("Desea seguir cargando nombres o quiere finalizar. Escriba Si o No");
                    validarCargaNombresApellidos = Console.ReadLine();
                    if (validarCargaNombresApellidos.Trim().ToLower().Replace(" ", "") == "si")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
            }


            x = 0;

            while (x >= 0)
            {
                Console.WriteLine("Ingrese un apellido");
                ListaApellidos.Add(Console.ReadLine());

                x++;
                if (x > 0)
                {
                    Console.WriteLine("Desea seguir cargando apellidos o quiere finalizar. Escriba Si o No");
                    validarCargaNombresApellidos = Console.ReadLine();
                    if (validarCargaNombresApellidos.Trim().ToLower() == "Si".ToLower())
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
            }


            Console.WriteLine("Ingrese uno de los nombres que agregó a la lista");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese uno de los apellido que agregó a la lista");
            string apellido = Console.ReadLine();


            int eleccion;

            Console.Write("Ingrese 1, si desea obtener los elementos en común entre las listas, o 2 si desea la cantidad total de nombres y apellidos. \n");
            bool validar = int.TryParse(Console.ReadLine(), out eleccion);




            List<string> ResultadoLista = new List<string>();

            switch (eleccion)
            {
                case 1:
                    /*
                    Cuando el usuario ingrese 1, a lo que se refiere la consigna de devolver una lista con elementos en común, en este
                    caso, será el nombre y apellido asociado de cada lista, según lo que pide el usuario.
                    */
                    ResultadoLista.Add(AsemejarIndices(ListaNombres, ListaApellidos, validar, nombre, nombre));
                    Console.WriteLine($"El usuario completo es: {ResultadoLista}");
                    break;

                    /*
                    Cuando el usuario ingrese 2, recibirá una lista con la cantidad total de nombres y apellidos cargados.
                    */
                case 2:
                    ResultadoLista = AsemejarIndices(ListaNombres, ListaApellidos, validar);
                    Console.Write($"La cantidad total de nombres es {ResultadoLista[0]} \n");
                    Console.Write($"y la cantidad total de apellidos es {ResultadoLista[1]} \n");


                    break;
            }


            Console.ReadKey();


        }


        static List<string> AsemejarIndices(List<string> listaNombres, List<string> listaApellidos, bool booleano, string nombre = "", string apellido = "")
        {


            if (booleano)
            {
                int x = 0;
                string nombreEnComun = string.Empty;


                //Puede ser que el usuario haya agregado el nombre en la lista de nombres.
                foreach (string elemento in listaNombres)
                {


                    if (nombre.Trim().Replace(" ", "").ToLower() == elemento.Trim().Replace(" ", "").ToLower())
                    {
                        nombreEnComun = listaNombres[x];
                    }

                    if (x < listaNombres.Count)
                    {
                        x++;
                    }
                   

                }

                //Puede ser que el usuario haya agregado el nombre en la lista de apellidos.
                x = 0;

                foreach (string elemento in listaApellidos)
                {
                    if (nombre.Trim().Replace(" ", "").ToLower() == elemento.Trim().Replace(" ", "").ToLower())
                    {
                        nombreEnComun = listaApellidos[x];
                    }

                    if (x < listaApellidos.Count)
                    {
                        x++;
                    }

                }




                x = 0;
                string apellidoEnComun = string.Empty;

                //Puede ser que el usuario haya agregado el apellido en la lista de nombres.
                foreach (string elemento in listaNombres)
                {
                    if (apellido.Trim().Replace(" ", "").ToLower() == elemento.Trim().Replace(" ", "").ToLower())
                    {
                        apellidoEnComun = listaNombres[x];
                    }

                    if (x < listaNombres.Count)
                    {
                        x++;
                    }
                }

                //Puede ser que el usuario haya agregado el apellido en la lista de apellidos.
                x = 0;

                foreach (string elemento in listaApellidos)
                {
                    if (apellido.Trim().Replace(" ", "").ToLower() == elemento.Trim().Replace(" ", "").ToLower())
                    {
                        apellidoEnComun = listaApellidos[x];
                    }

                    if (x < listaApellidos.Count)
                    {
                        x++;
                    }
                }


                List<string> listaNombreApellido = new List<string>();

                listaNombreApellido.Add(nombreEnComun + " " + apellidoEnComun);
                return listaNombreApellido;

            }
            else
            {
                int x = 0;
                int contadorNombres = 0;

                for (x = 0; x < listaNombres.Count; x++)
                {
                    contadorNombres++;
                }

                int contadorApellidos = 0;

                for (x = 0; x < listaApellidos.Count; x++)
                {
                    contadorApellidos++;
                }

                List<string> CantidadNombresApellidos = new List<string>();

                CantidadNombresApellidos.Add(contadorNombres.ToString());
                CantidadNombresApellidos.Add(contadorApellidos.ToString());

                return CantidadNombresApellidos;

            }

        }
    }
}
