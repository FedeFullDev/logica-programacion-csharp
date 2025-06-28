/*
 * Dado un array de enteros ordenado y sin repetidos,
 * crea una función que calcule y retorne todos los que faltan entre
 * el mayor y el menor.
 * - Lanza un error si el array de entrada no es correcto.
 */


using System.Collections.Generic;
using System.Linq;
using System.Numerics;



Console.WriteLine("Ingrese los números");
string[] numeros = Console.ReadLine().Select(c => c.ToString()).ToArray();

HashSet<int> SetNums = numeros.Select(n => int.Parse(n.Trim())).ToHashSet();

int[] ArrayNums = SetNums.ToArray();

ArrayNums = OrderArrayAsc(ArrayNums);
Console.WriteLine($"Números ordenados: {ArrayNums.Select(n => n.ToString()).Aggregate((a, b) => a + ", " + b)}");









Console.WriteLine($"Números faltantes: {FindArrayMissingNumbers(ArrayNums).Select(n => n.ToString()).Aggregate((a, b) => a + ", " + b)}");


int[] OrderArrayAsc(int[] nums)
{
   int min = 0;
    int aux = 0;
   
       for (int i = 0; i < nums.Length -1; i++){
        for (int j = i + 1; j < nums.Length; j++){
            if (nums[i] < nums[j])
            {
                min = nums[i];
            }else{
                min = nums[j];
                aux = nums[i];
                nums[i] = min;
                nums[j] = aux;
            }
        }
    }
    

    return nums;
}


int[] FindArrayMissingNumbers(int[] nums)
{
    List<int> numbers = new List<int>();
    

    for (int i = 0; i <= nums.Length; i++){
        if(nums.Contains(i)){
            continue;
        }else{
            numbers.Add(i);
        }
    }

    numbers = OrderArrayAsc(numbers.ToArray()).ToList();
    return numbers.ToArray();       
}