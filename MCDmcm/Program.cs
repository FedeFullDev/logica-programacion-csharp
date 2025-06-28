/*
 * Crea dos funciones, una que calcule el máximo común divisor (MCD) y otra
 * que calcule el mínimo común múltiplo (mcm) de dos números enteros.
 * - No se pueden utilizar operaciones del lenguaje que
 *   lo resuelvan directamente.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using Microsoft.Win32.SafeHandles;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Máximo común divisor entre 2 números");

        Console.WriteLine("Ingrese el primer número:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        int b = int.Parse(Console.ReadLine());
         int MCDResult = MCDOptimizado(a, b);
        Console.WriteLine($"El máximo común divisor de {a} y {b} es: {MCDResult}");

        Console.WriteLine("Mínimo común múltiplo entre 2 números");

         Console.WriteLine("Ingrese el primer número:");
         a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
         b = int.Parse(Console.ReadLine());
         int mcmResult = mcm(a, b);
        Console.WriteLine($"El mínimo común múltiplo de {a} y {b} es: {mcmResult}");

    }

    static int MCD(int a, int b)
    {
       int maxNumA = a;
       int[] maxNumsA = new int[maxNumA];
        for (int i = 0; i < maxNumA; i++) {
            maxNumsA[i] = i + 1;
       }

       int maxNumB = b;
         int[] maxNumsB = new int[maxNumB];
        for (int i = 0; i < maxNumB; i++) {
            maxNumsB[i] = i + 1;
        }

        HashSet<int> maxNumsUnificado = new HashSet<int>();

        maxNumsUnificado.UnionWith(maxNumsA);
        maxNumsUnificado.UnionWith(maxNumsB);
        

        int[]  maxNumsUnificadoArray = maxNumsUnificado.ToArray();

        int num = 0;
        int MCD = 1;
        while (num < maxNumsUnificadoArray.Length)
        {
               if(a % maxNumsUnificadoArray[num] == 0 && b % maxNumsUnificadoArray[num] == 0)
                {
                    MCD = maxNumsUnificadoArray[num];
                }

            num++;
        }
        
    return MCD;
    }

    static int MCDOptimizado(int a, int b){
        int menorNum = (a < b) ? a : b;
        int MCD = 1;
        for (int i = 1; i <= menorNum; i++){
            if(a % i == 0 && b % i == 0)
            {
                MCD = i;
            }
        }
        return MCD;
    }


    static int mcm(int a, int b)
    {
        bool validarNum = false;
        int mcm = 1;
        int maxAb = (a > b) ? a : b;
        int cont = maxAb;

        while (validarNum != true)
        {
            if (cont % a == 0 && cont % b == 0)
            {
                mcm = cont;
                validarNum = true;
                
            }
            else
            {
                cont++;
            }

           
        }
          
          return mcm;

    }

}